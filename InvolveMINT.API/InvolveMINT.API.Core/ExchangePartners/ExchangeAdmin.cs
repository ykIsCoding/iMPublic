using InvolveMINT.API.SharedKernel;

namespace InvolveMINT.API.Core.Aggregates.ExchangePartners
{
  public class ExchangeAdmin : EntityBase<string>
  {
    private ExchangeAdmin()
    {
    }

    public DateTime DatePermitted { get; set; }

    public bool SuperAdmin { get; set; }

    public string? UserId { get; set; }

    public string? ExchangePartnerId { get; set; }
  }
}

