using InvolveMINT.API.SharedKernel;

namespace InvolveMINT.API.Core.Aggregates.Offers
{
  public class Offer : EntityBase<string>, IAggregateRoot
  {
    private Offer()
    {
    }

    public OfferListingStatus ListingStatus { get; set; } = OfferListingStatus.PRIVATE;

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public int Price { get; set; }

    public string[] ImagesFilePaths { get; set; } = null!;

    public DateTime DateUpdated { get; set; }

    public DateTime DateCreated { get; set; }

    public string? ChangeMakerId { get; set; }

    public string? ExchangePartnerId { get; set; }

    public string? ServePartnerId { get; set; }
  }
}

