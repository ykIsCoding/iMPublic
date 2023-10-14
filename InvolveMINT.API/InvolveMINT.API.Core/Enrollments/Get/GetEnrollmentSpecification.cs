using Ardalis.Specification;

namespace InvolveMINT.API.Core.Aggregates.Enrollments.Get
{
  public class GetEnrollmentSpecification : Specification<Enrollment>
  {
    public GetEnrollmentSpecification(GetEnrollmentQueryFilter filter)
    {
      Query.Where(x => x.ChangeMakerId == filter.changeMakerId);
    }
  }
}

