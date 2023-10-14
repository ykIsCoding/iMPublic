using Ardalis.GuardClauses;
using InvolveMINT.API.Core.Aggregates.ChangeMakers;
using InvolveMINT.API.Core.Aggregates.Enrollments;
using InvolveMINT.API.Core.Aggregates.Enrollments.Get;
using InvolveMINT.API.Core.Aggregates.Projects;
using InvolveMINT.API.SharedKernel;
using InvolveMINT.API.Core.Services.Interfaces;

namespace InvolveMINT.API.Core.Services;

public class EnrollInProjectService : IEnrollInProjectService
{
    private readonly IRepository<Project> projectRepository;
    private readonly IReadRepository<ChangeMaker> changeMakerRepository;
    private readonly IRepository<Enrollment> enrollmentRepository;

  public EnrollInProjectService(IRepository<Project> projectRepository, IReadRepository<ChangeMaker> changeMakerRepository, IRepository<Enrollment> enrollmentRepository)
  {
    this.projectRepository = projectRepository;
    this.changeMakerRepository = changeMakerRepository;
    this.enrollmentRepository = enrollmentRepository;
  }

  public async Task<Enrollment> EnrollInProject(string changeMakerId, string projectId)
  {
    Project project = await GetProject(projectId);

    await VerifyNotMaxEnrollmentCount(projectId, project);

    await VerifyEnrollmentDoesNotExist(changeMakerId, projectId);

    Enrollment result = Enrollment.CreateInitialEnrollmentApplication(changeMakerId, projectId);

    return await enrollmentRepository.AddAsync(result);

  }

  private async Task VerifyEnrollmentDoesNotExist(string changeMakerId, string projectId)
  {
    GetEnrollmentQueryFilter existingEnrollmentFilter = new(changeMakerId, projectId);

    GetEnrollmentSpecification existingEnrollmentSpecification = new(existingEnrollmentFilter);

    Enrollment? existingEnrollment = await enrollmentRepository.FirstOrDefaultAsync(existingEnrollmentSpecification);

    if (existingEnrollment != null)
      throw new InvalidOperationException($"Enrollment for ChangemakerId {changeMakerId} and project id {projectId}");
  }

  private async Task VerifyNotMaxEnrollmentCount(string projectId, Project project)
  {
    GetEnrollmentQueryFilter currentEnrollmentCountFilter = new(projectId: projectId);

    GetEnrollmentSpecification currentEnrollmentCountSpec = new(currentEnrollmentCountFilter);

    int currentEnrollmentsCount = await enrollmentRepository.CountAsync(currentEnrollmentCountSpec);

    if (currentEnrollmentsCount >= project.MaxChangeMakers)
      throw new InvalidOperationException($"Max Number of Change Makers already reached for project projectId: {projectId}, projectName: {project.Title}");
  }

  private async Task<Project> GetProject(string projectId)
  {
    Project? project = await projectRepository.GetByIdAsync(projectId);

    Guard.Against.Null(project, projectId, $"No project found for ${projectId}");

    return project;
  }
}
