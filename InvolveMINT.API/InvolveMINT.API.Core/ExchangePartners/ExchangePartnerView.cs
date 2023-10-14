namespace InvolveMINT.API.Core.Aggregates.ExchangePartners
{
  public class ExchangePartnerView
  {
    private ExchangePartnerView()
    {
    }

    public string? Id { get; set; }

    public int? ReceivedThisMonth { get; set; }
  }
}

