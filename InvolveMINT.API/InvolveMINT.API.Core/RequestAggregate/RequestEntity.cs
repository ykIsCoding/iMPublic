using InvolveMINT.API.SharedKernel;

namespace InvolveMINT.API.Core.RequestAggregate
{
  public class RequestEntity : EntityBase, IAggregateRoot
  {
    public RequestEntity()
    {
    }

    public RequestListingStatus ListingStatus { get; set; } = RequestListingStatus.PRIVATE;

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public bool PriceStatus { get; set; }

    public int Price { get; set; }

    public string[] ImagesFilePaths { get; set; } = null!;

    public DateTime DateUpdated { get; set; }

    public DateTime DateCreated { get; set; }

    public Guid? ChangeMakerId { get; set; }

    public Guid? ExchangePartnerId { get; set; }

    public Guid? ServePartnerId { get; set; }
  }
}

