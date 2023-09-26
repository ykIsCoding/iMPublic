using Microsoft.AspNetCore.Mvc;
using InvolveMINT.API.Core.EnrollmentAggregate.Get;
using InvolveMINT.API.UseCases.Enrollments.Get;
using InvolveMINT.API.Core.EnrollmentAggregate;
using InvolveMINT.API.SharedKernel;

namespace InvolveMINT.API.Controllers;

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
  public async Task Get()
  {
    var test = await _repository.ListAsync();
    EnrollmentEntity? result = await _repository.GetByIdAsync(Guid.Parse("e0d31bd1-2d26-4a84-8399-5e10e3dba690"));
  }
}

