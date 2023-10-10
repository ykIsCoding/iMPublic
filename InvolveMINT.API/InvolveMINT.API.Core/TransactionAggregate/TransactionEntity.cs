using InvolveMINT.API.SharedKernel;

namespace InvolveMINT.API.Core.TransactionAggregate
{
  public class TransactionEntity : EntityBase<string>, IAggregateRoot
  {
    private TransactionEntity()
    {
    }

    public DateTime DateTransacted { get; set; }

    public int Amount { get; set; }

    public string Memo { get; set; } = null!;

    public string? EpAudibleCode { get; set; }

    public string? SenderChangeMakerId { get; set; }

    public string? SenderServePartnerId { get; set; }

    public string? SenderExchangePartnerId { get; set; }

    public string? ReceiverChangeMakerId { get; set; }

    public string? ReceiverServePartnerId { get; set; }

    public string? ReceiverExchangePartnerId { get; set; }
  }
}

