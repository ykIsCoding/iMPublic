using InvolveMINT.API.SharedKernel;

namespace InvolveMINT.API.Core.Aggregates.Vouchers
{
  public class LinkedVoucherOffer : EntityBase<string>
  {
    private LinkedVoucherOffer()
    {
    }

    public int Quantity { get; set; }

    public string? VoucherId { get; set; }

    public string? OfferId { get; set; }
  }
}

