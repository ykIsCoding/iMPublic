namespace InvolveMINT.API.Core.ExchangePartnerAggregate
{
  public class ExchangePartnerViewEntity
  {
    private ExchangePartnerViewEntity()
    {
    }

    public string? Id { get; set; }

    public int? ReceivedThisMonth { get; set; }
  }
}

