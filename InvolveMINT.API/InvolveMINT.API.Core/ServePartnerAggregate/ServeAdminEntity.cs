using InvolveMINT.API.SharedKernel;

namespace InvolveMINT.API.Core.ServePartnerAggregate
{
  public class ServeAdminEntity : EntityBase
  {
    public ServeAdminEntity()
    {
    }

    public DateTime DatePermitted { get; set; }

    public bool SuperAdmin { get; set; }

    public Guid? UserId { get; set; }

    public Guid? ServePartnerId { get; set; }
  }
}

