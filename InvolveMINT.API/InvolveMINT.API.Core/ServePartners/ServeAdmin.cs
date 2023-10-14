using InvolveMINT.API.SharedKernel;

namespace InvolveMINT.API.Core.Aggregates.ServePartners
{
  public class ServeAdmin : EntityBase<string>
  {
    private ServeAdmin()
    {
    }

    public DateTime DatePermitted { get; set; }

    public bool SuperAdmin { get; set; }

    public string? UserId { get; set; }

    public string? ServePartnerId { get; set; }
  }
}

