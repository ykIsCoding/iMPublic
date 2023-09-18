using Ardalis.SmartEnum;

namespace InvolveMINT.API.Core.OfferAggregate
{
  public class OfferListingStatus : SmartEnum<OfferListingStatus>
  {
    public static readonly OfferListingStatus PUBLIC = new(nameof(PUBLIC).ToLower(), 0);
    public static readonly OfferListingStatus UNLISTED = new(nameof(UNLISTED).ToLower(), 1);
    public static readonly OfferListingStatus PRIVATE = new(nameof(PRIVATE).ToLower(), 2);

    protected OfferListingStatus(string name, int value) : base(name, value) { }

  }
}

