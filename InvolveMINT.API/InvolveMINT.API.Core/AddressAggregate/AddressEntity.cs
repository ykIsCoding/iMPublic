using InvolveMINT.API.SharedKernel;

namespace InvolveMINT.API.Core.AddressAggregate
{
  public class AddressEntity : EntityBase, IAggregateRoot
  {
    public AddressEntity(string address1, string address2, string address3, string city, string state, string zip, string country = "United States")
    {
      Address1 = address1;
      Address2 = address2;
      Address3 = address3;
      City = city;
      State = state;
      Zip = zip;
      Country = country;
    }

    public string Address1 { get; set; }

    public string Address2 { get; set; }

    public string Address3 { get; set; }

    public string City { get; set; }

    public string State { get; set; }

    public string Zip { get; set; }

    public string Country { get; set; }

  }
}