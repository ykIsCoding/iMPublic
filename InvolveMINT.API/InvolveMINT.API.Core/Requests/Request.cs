using InvolveMINT.API.SharedKernel;

namespace InvolveMINT.API.Core.Aggregates.Requests
{
  public class Request : EntityBase<string>, IAggregateRoot
  {
    private Request()
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

    public string? ChangeMakerId { get; set; }

    public string? ExchangePartnerId { get; set; }

    public string? ServePartnerId { get; set; }
  }
}

