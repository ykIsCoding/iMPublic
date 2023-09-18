namespace InvolveMINT.API.Core.ExchangePartnerAggregate
{
  public class ExchangePartnerViewEntity
  {
    public ExchangePartnerViewEntity()
    {
    }

    public Guid? Id { get; set; }

    public int? ReceivedThisMonth { get; set; }
  }
}

