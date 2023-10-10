using InvolveMINT.API.SharedKernel;

namespace InvolveMINT.API.Core.AddressAggregate
{
  public class AddressEntity : EntityBase<string>, IAggregateRoot
  {
    private AddressEntity()
    {
    }

    public string Address1 { get; set; } = null!;

    public string? Address2 { get; set; }

    public string? Address3 { get; set; }

    public string City { get; set; } = null!;

    public string State { get; set; } = null!;

    public string Zip { get; set; } = null!;

    public string Country { get; set; } = "United States";

  }
}