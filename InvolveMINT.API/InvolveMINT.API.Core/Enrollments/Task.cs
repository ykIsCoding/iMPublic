using InvolveMINT.API.SharedKernel;

namespace InvolveMINT.API.Core.Aggregates.Enrollments
{
  public class ProofOfImpactTask : EntityBase<string>
  {
    private ProofOfImpactTask()
    {
    }

    public string PoiId { get; set; }
  }
}

