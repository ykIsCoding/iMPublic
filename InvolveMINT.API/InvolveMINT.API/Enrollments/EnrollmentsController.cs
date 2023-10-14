using Microsoft.AspNetCore.Mvc;
using InvolveMINT.API.Core.Aggregates.Enrollments;
using InvolveMINT.API.SharedKernel;
using InvolveMINT.API.Core.Services.Interfaces;

namespace InvolveMINT.API.Enrollments;

[ApiController]
[Route("[controller]/[action]")]
public class EnrollmentsController : ControllerBase
{
  private readonly ILogger<EnrollmentsController> _logger;
  private readonly IReadRepository<Enrollment> _repository;
  private readonly IEnrollInProjectService _enrollInProjectService;

  public EnrollmentsController(ILogger<EnrollmentsController> logger, IReadRepository<Enrollment> repository, IEnrollInProjectService enrollInProjectService)
  {
    _logger = logger;
    _repository = repository;
    _enrollInProjectService = enrollInProjectService;
  }

  // [HttpGet(Name = "GetEnrollmentByFilter")]
  // public async Task<List<Enrollment>?> Get([FromQueryAttribute] EnrollmentQueryFilter filter)
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
  public async Task<Enrollment> StartEnrollment([FromQuery] string changeMakerId, [FromQuery] string projectId)
  {
    var result = await _repository.ListAsync();
    return await _enrollInProjectService.EnrollInProject(changeMakerId, projectId);
  }
}

