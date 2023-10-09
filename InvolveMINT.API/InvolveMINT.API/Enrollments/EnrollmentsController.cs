using Microsoft.AspNetCore.Mvc;
using InvolveMINT.API.Core.EnrollmentAggregate;
using InvolveMINT.API.SharedKernel;
using InvolveMINT.API.Core;
using Ardalis.GuardClauses;

namespace InvolveMINT.API.Enrollments;

[ApiController]
[Route("[controller]/[action]")]
public class EnrollmentsController : ControllerBase
{
  private readonly ILogger<EnrollmentsController> _logger;
  private readonly IReadRepository<EnrollmentEntity> _repository;
  private readonly IEnrollInProjectService _enrollInProjectService;

  public EnrollmentsController(ILogger<EnrollmentsController> logger, IReadRepository<EnrollmentEntity> repository, IEnrollInProjectService enrollInProjectService)
  {
    _logger = logger;
    _repository = repository;
    _enrollInProjectService = enrollInProjectService;
  }

  // [HttpGet(Name = "GetEnrollmentByFilter")]
  // public async Task<List<EnrollmentEntity>?> Get([FromQueryAttribute] EnrollmentQueryFilter filter)
  // {
  //   /*todo validate the filter including
  //     - One of the properties must be set with a non empty guid
  //     - Enrollments access is limited to the change maker being able to see their own
  //         and project admin being able to see enrollments for that project
  //   */
  //   return null;
  // }

  [HttpPost]
  [Route("/start-enrollment")]
  public async Task<EnrollmentEntity> StartEnrollment([FromQuery] string changeMakerId, [FromQuery] string projectId)
  {
    return await _enrollInProjectService.EnrollInProject(changeMakerId, projectId);
  }
}

