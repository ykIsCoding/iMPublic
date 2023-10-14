using InvolveMINT.API.SharedKernel;
namespace InvolveMINT.API.Core.Aggregates.Credits
{
  public class Credit : EntityBase<string>, IAggregateRoot
  {
    private Credit()
    {
    }

    public int Amount { get; set; }

    public DateTime DateMinted { get; set; }

    public bool Escrow { get; set; }

    public string? PoiId { get; set; }

    public string? ChangeMakerId { get; set; }

    public string? ServePartnerId { get; set; }

    public string? ExchangePartnerId { get; set; }
  }
}

