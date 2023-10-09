using Ardalis.GuardClauses;
using InvolveMINT.API.Core.ChangeMakerAggregate;
using InvolveMINT.API.Core.EnrollmentAggregate;
using InvolveMINT.API.Core.EnrollmentAggregate.Get;
using InvolveMINT.API.Core.ProjectAggregate;
using InvolveMINT.API.SharedKernel;

namespace InvolveMINT.API.Core.Services;

public class EnrollInProjectService : IEnrollInProjectService
{
    private readonly IRepository<ProjectEntity> projectRepository;
    private readonly IReadRepository<ChangeMakerEntity> changeMakerRepository;
    private readonly IRepository<EnrollmentEntity> enrollmentRepository;

  public EnrollInProjectService(IRepository<ProjectEntity> projectRepository, IReadRepository<ChangeMakerEntity> changeMakerRepository, IRepository<EnrollmentEntity> enrollmentRepository)
  {
    this.projectRepository = projectRepository;
    this.changeMakerRepository = changeMakerRepository;
    this.enrollmentRepository = enrollmentRepository;
  }

  public async Task<EnrollmentEntity> EnrollInProject(string changeMakerId, string projectId)
  {
    ProjectEntity project = await GetProject(projectId);

    await VerifyNotMaxEnrollmentCount(projectId, project);

    await VerifyEnrollmentDoesNotExist(changeMakerId, projectId);

    EnrollmentEntity result = EnrollmentEntity.CreateInitialEnrollmentApplication(changeMakerId, projectId);

    return await enrollmentRepository.AddAsync(result);

  }

  private async Task VerifyEnrollmentDoesNotExist(string changeMakerId, string projectId)
  {
    GetEnrollmentQueryFilter existingEnrollmentFilter = new(changeMakerId, projectId);

    GetEnrollmentSpecification existingEnrollmentSpecification = new(existingEnrollmentFilter);

    EnrollmentEntity? existingEnrollment = await enrollmentRepository.FirstOrDefaultAsync(existingEnrollmentSpecification);

    if (existingEnrollment != null)
      throw new InvalidOperationException($"Enrollment for ChangemakerId {changeMakerId} and project id {projectId}");
  }

  private async Task VerifyNotMaxEnrollmentCount(string projectId, ProjectEntity project)
  {
    GetEnrollmentQueryFilter currentEnrollmentCountFilter = new(projectId: projectId);

    GetEnrollmentSpecification currentEnrollmentCountSpec = new(currentEnrollmentCountFilter);

    int currentEnrollmentsCount = await enrollmentRepository.CountAsync(currentEnrollmentCountSpec);

    if (currentEnrollmentsCount >= project.MaxChangeMakers)
      throw new InvalidOperationException($"Max Number of Change Makers already reached for project projectId: {projectId}, projectName: {project.Title}");
  }

  private async Task<ProjectEntity> GetProject(string projectId)
  {
    ProjectEntity? project = await projectRepository.GetByIdAsync(projectId);

    Guard.Against.Null(project, projectId, $"No project found for ${projectId}");

    return project;
  }
}
