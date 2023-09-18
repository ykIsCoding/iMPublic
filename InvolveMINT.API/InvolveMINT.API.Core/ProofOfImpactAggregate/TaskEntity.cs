using InvolveMINT.API.SharedKernel;

namespace InvolveMINT.API.Core.ProofOfImpactAggregate
{
  public class TaskEntity : EntityBase
  {
    public TaskEntity()
    {
    }

    public Guid PoiId { get; set; }
  }
}

