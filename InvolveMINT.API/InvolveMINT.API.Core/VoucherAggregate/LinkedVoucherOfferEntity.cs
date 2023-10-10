using InvolveMINT.API.SharedKernel;

namespace InvolveMINT.API.Core.VoucherAggregate
{
  public class LinkedVoucherOfferEntity : EntityBase<string>
  {
    private LinkedVoucherOfferEntity()
    {
    }

    public int Quantity { get; set; }

    public string? VoucherId { get; set; }

    public string? OfferId { get; set; }
  }
}

