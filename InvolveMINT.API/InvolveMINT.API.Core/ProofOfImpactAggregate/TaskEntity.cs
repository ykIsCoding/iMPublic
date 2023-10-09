using InvolveMINT.API.SharedKernel;

namespace InvolveMINT.API.Core.ProofOfImpactAggregate
{
  public class TaskEntity : EntityBase<string>
  {
    public TaskEntity()
    {
    }

    public string PoiId { get; set; }
  }
}

