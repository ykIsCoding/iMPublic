using InvolveMINT.API.SharedKernel;

namespace InvolveMINT.API.Core.ExchangePartnerAggregate
{
  public class ExchangeAdminEntity : EntityBase<string>
  {
    public ExchangeAdminEntity()
    {
    }

    public DateTime DatePermitted { get; set; }

    public bool SuperAdmin { get; set; }

    public string? UserId { get; set; }

    public string? ExchangePartnerId { get; set; }
  }
}

