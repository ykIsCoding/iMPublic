using InvolveMINT.API.SharedKernel;

namespace InvolveMINT.API.Core.ServePartnerAggregate
{
  public class ServeAdminEntity : EntityBase<string>
  {
    public ServeAdminEntity()
    {
    }

    public DateTime DatePermitted { get; set; }

    public bool SuperAdmin { get; set; }

    public string? UserId { get; set; }

    public string? ServePartnerId { get; set; }
  }
}

