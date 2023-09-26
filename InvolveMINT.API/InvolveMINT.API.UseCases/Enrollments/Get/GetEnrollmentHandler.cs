using InvolveMINT.API.Core.EnrollmentAggregate.Get;
using InvolveMINT.API.Core.EnrollmentAggregate;
using InvolveMINT.API.SharedKernel;


namespace InvolveMINT.API.UseCases.Enrollments.Get
{
  public class GetEnrollmentHandler
  {
    private readonly IReadRepository<EnrollmentEntity> _repository;

    public GetEnrollmentHandler(IReadRepository<EnrollmentEntity> repository)
    {
      _repository = repository;
    }

    public async Task Handle(GetEnrollmentQueryFilter filter)
    {
      GetEnrollmentSpecification spec = new GetEnrollmentSpecification(filter);

      EnrollmentEntity? result = await _repository.FirstOrDefaultAsync(spec);
    }
  }
}

