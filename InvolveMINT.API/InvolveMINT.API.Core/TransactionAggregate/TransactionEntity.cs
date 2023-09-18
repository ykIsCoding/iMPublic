using InvolveMINT.API.SharedKernel;

namespace InvolveMINT.API.Core.TransactionAggregate
{
  public class TransactionEntity : EntityBase, IAggregateRoot
  {
    public TransactionEntity()
    {
    }

    public DateTime DateTransacted { get; set; }

    public int Amount { get; set; }

    public string Memo { get; set; } = null!;

    public string? EpAudibleCode { get; set; }

    public Guid? SenderChangeMakerId { get; set; }

    public Guid? SenderServePartnerId { get; set; }

    public Guid? SenderExchangePartnerId { get; set; }

    public Guid? ReceiverChangeMakerId { get; set; }

    public Guid? ReceiverServePartnerId { get; set; }

    public Guid? ReceiverExchangePartnerId { get; set; }
  }
}

