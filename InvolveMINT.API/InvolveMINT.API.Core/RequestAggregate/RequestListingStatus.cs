using Ardalis.SmartEnum;

namespace InvolveMINT.API.Core.RequestAggregate
{
  public class RequestListingStatus : SmartEnum<RequestListingStatus>
  {
    public static readonly RequestListingStatus PUBLIC = new(nameof(PUBLIC).ToLower(), 0);
    public static readonly RequestListingStatus UNLISTED = new(nameof(UNLISTED).ToLower(), 1);
    public static readonly RequestListingStatus PRIVATE = new(nameof(PRIVATE).ToLower(), 2);

    protected RequestListingStatus(string name, int value) : base(name, value) { }

  }
}

