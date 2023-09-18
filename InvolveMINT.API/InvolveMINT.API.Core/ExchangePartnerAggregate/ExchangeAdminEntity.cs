using InvolveMINT.API.SharedKernel;

namespace InvolveMINT.API.Core.ExchangePartnerAggregate
{
  public class ExchangeAdminEntity : EntityBase
  {
    public ExchangeAdminEntity()
    {
    }

    public DateTime DatePermitted { get; set; }

    public bool SuperAdmin { get; set; }

    public Guid? UserId { get; set; }

    public Guid? ExchangePartnerId { get; set; }
  }
}

