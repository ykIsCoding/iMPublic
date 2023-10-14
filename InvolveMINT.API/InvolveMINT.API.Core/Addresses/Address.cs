using InvolveMINT.API.SharedKernel;

namespace InvolveMINT.API.Core.Aggregates.Addresses
{
  public class Address : EntityBase<string>, IAggregateRoot
  {
    private Address()
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