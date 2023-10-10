
namespace InvolveMINT.API.Core.ChangeMakerAggregate
{
  public class ChangeMakerViewEntity
  {
    private ChangeMakerViewEntity()
    {
    }

    public string? Id { get; set; }

    public int? PoiApproved { get; set; }

    public int? SecondsCompleted { get; set; }

    public long? SpentCredits { get; set; }

    public long? EarnedCredits { get; set; }
  }
}

