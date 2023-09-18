using InvolveMINT.API.SharedKernel;

namespace InvolveMINT.API.Core.OfferAggregate
{
  public class OfferEntity : EntityBase, IAggregateRoot
  {
    public OfferEntity()
    {
    }

    public OfferListingStatus ListingStatus { get; set; } = OfferListingStatus.PRIVATE;

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public int Price { get; set; }

    public string[] ImagesFilePaths { get; set; } = null!;

    public DateTime DateUpdated { get; set; }

    public DateTime DateCreated { get; set; }

    public Guid? ChangeMakerId { get; set; }

    public Guid? ExchangePartnerId { get; set; }

    public Guid? ServePartnerId { get; set; }
  }
}

