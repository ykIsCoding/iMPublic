using InvolveMINT.API.SharedKernel;

namespace InvolveMINT.API.Core.Aggregates.Vouchers
{
  public class Voucher : EntityBase<string>, IAggregateRoot
  {
    private Voucher()
    {
    }

    public string Code { get; set; } = null!;

    public int Amount { get; set; }

    public DateTime DateCreated { get; set; }

    public string? BuyerId { get; set; }

    public DateTime? DateExpires { get; set; }

    public DateTime? DateRefunded { get; set; }

    public DateTime? DateArchived { get; set; }

    public DateTime? DateRedeemed { get; set; }

    public string SellerId { get; set; }

    public string? ChangeMakerReceiverId { get; set; }

    public string? ServePartnerReceiverId { get; set; }

    public string? ExchangePartnerReceiverId { get; set; }
  }
}

