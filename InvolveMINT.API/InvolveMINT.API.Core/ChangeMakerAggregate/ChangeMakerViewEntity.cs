
namespace InvolveMINT.API.Core.ChangeMakerAggregate
{
  public class ChangeMakerViewEntity
  {
    public ChangeMakerViewEntity()
    {
    }

    public Guid? Id { get; set; }

    public int? PoiApproved { get; set; }

    public int? SecondsCompleted { get; set; }

    public long? SpentCredits { get; set; }

    public long? EarnedCredits { get; set; }
  }
}

