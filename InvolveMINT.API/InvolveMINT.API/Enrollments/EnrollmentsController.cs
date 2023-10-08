using Microsoft.AspNetCore.Mvc;
using InvolveMINT.API.Core.EnrollmentAggregate;
using InvolveMINT.API.SharedKernel;

namespace InvolveMINT.API.Enrollments;

[ApiController]
[Route("[controller]")]
public class EnrollmentsController : ControllerBase
{
  private readonly ILogger<EnrollmentsController> _logger;
  private readonly IReadRepository<EnrollmentEntity> _repository;

  public EnrollmentsController(ILogger<EnrollmentsController> logger, IReadRepository<EnrollmentEntity> repository)
  {
    _logger = logger;
    _repository = repository;
  }

  [HttpGet(Name = "GetEnrollmentByFilter")]
  public async Task<List<EnrollmentEntity>?> Get([FromQueryAttribute] EnrollmentQueryFilter filter)
  {
    /*todo validate the filter including
      - One of the properties must be set with a non empty guid
      - Enrollments access is limited to the change maker being able to see their own
          and project admin being able to see enrollments for that project
    */
    return null;
  }
}

