using InvolveMINT.API.Core.Aggregates.Enrollments.Get;
using InvolveMINT.API.Core.Aggregates.Enrollments;
using InvolveMINT.API.SharedKernel;


namespace InvolveMINT.API.UseCases.Enrollments.Get
{
  public class GetEnrollmentHandler
  {
    private readonly IReadRepository<Enrollment> _repository;

    public GetEnrollmentHandler(IReadRepository<Enrollment> repository)
    {
      _repository = repository;
    }

    public async Task Handle(GetEnrollmentQueryFilter filter)
    {
      GetEnrollmentSpecification spec = new GetEnrollmentSpecification(filter);

      Enrollment? result = await _repository.FirstOrDefaultAsync(spec);
    }
  }
}

