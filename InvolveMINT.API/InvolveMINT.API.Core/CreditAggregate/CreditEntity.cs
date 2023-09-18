using InvolveMINT.API.SharedKernel;
namespace InvolveMINT.API.Core.CreditAggregate
{
  public class CreditEntity : EntityBase, IAggregateRoot
  {
    public CreditEntity()
    {
    }

    public int Amount { get; set; }

    public DateTime DateMinted { get; set; }

    public bool Escrow { get; set; }

    public Guid? PoiId { get; set; }

    public Guid? ChangeMakerId { get; set; }

    public Guid? ServePartnerId { get; set; }

    public Guid? ExchangePartnerId { get; set; }
  }
}

