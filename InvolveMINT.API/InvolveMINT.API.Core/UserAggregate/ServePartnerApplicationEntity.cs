using InvolveMINT.API.SharedKernel;

namespace InvolveMINT.API.Core.UserAggregate
{
  public class ServePartnerApplicationEntity : EntityBase
  {
    public ServePartnerApplicationEntity()
    {
    }

    public string Email { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public string Website { get; set; } = null!;

    public DateTime DateCreated { get; set; }

    public Guid? UserId { get; set; }

    public Guid? HandleId { get; set; }

    public Guid? AddressId { get; set; }
  }
}

