using InvolveMINT.API.SharedKernel;

namespace InvolveMINT.API.Core.VoucherAggregate
{
  public class VoucherEntity : EntityBase, IAggregateRoot
  {
    public VoucherEntity()
    {
    }

    public string Code { get; set; } = null!;

    public int Amount { get; set; }

    public DateTime DateCreated { get; set; }

    public Guid? BuyerId { get; set; }

    public DateTime? DateExpires { get; set; }

    public DateTime? DateRefunded { get; set; }

    public DateTime? DateArchived { get; set; }

    public DateTime? DateRedeemed { get; set; }

    public Guid SellerId { get; set; }

    public Guid? ChangeMakerReceiverId { get; set; }

    public Guid? ServePartnerReceiverId { get; set; }

    public Guid? ExchangePartnerReceiverId { get; set; }
  }
}

