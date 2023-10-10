using InvolveMINT.API.SharedKernel;

namespace InvolveMINT.API.Core.EnrollmentAggregate
{
  public class TaskEntity : EntityBase<string>
  {
    private TaskEntity()
    {
    }

    public string PoiId { get; set; }
  }
}

