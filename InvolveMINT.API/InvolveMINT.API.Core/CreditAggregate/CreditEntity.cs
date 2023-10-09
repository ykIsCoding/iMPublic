using InvolveMINT.API.SharedKernel;
namespace InvolveMINT.API.Core.CreditAggregate
{
  public class CreditEntity : EntityBase<string>, IAggregateRoot
  {
    public CreditEntity()
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

