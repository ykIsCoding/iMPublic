using InvolveMINT.API.SharedKernel;

namespace InvolveMINT.API.Core.VoucherAggregate
{
  public class LinkedVoucherOfferEntity : EntityBase
  {
    public LinkedVoucherOfferEntity()
    {
    }

    public int Quantity { get; set; }

    public Guid? VoucherId { get; set; }

    public Guid? OfferId { get; set; }
  }
}

