using Ardalis.Specification;

namespace InvolveMINT.API.Core.EnrollmentAggregate.Get
{
  public class GetEnrollmentSpecification : Specification<EnrollmentEntity>
  {
    public GetEnrollmentSpecification(GetEnrollmentQueryFilter filter)
    {
      Query.Where(x => x.ChangeMakerId == filter.changeMakerId);
    }
  }
}

