
namespace InvolveMINT.API.Core.Aggregates.ChangeMakers
{
  public class ChangeMakerView
  {
    private ChangeMakerView()
    {
    }

    public string? Id { get; set; }

    public int? PoiApproved { get; set; }

    public int? SecondsCompleted { get; set; }

    public long? SpentCredits { get; set; }

    public long? EarnedCredits { get; set; }
  }
}

