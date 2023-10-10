using InvolveMINT.API.SharedKernel;

namespace InvolveMINT.API.Core.ServePartnerAggregate
{
  public class ServePartnerApplicationEntity : EntityBase<string>
  {
    private ServePartnerApplicationEntity()
    {
    }

    public string Email { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public string Website { get; set; } = null!;

    public DateTime DateCreated { get; set; }

    public string? UserId { get; set; }

    public string? HandleId { get; set; }

    public string? AddressId { get; set; }
  }
}

