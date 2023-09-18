using Ardalis.SmartEnum;
using InvolveMINT.API.Core.ExchangePartnerAggregate;

namespace InvolveMINT.API.Core.ProjectAggregate
{
  public class ProjectListingStatus : SmartEnum<ProjectListingStatus>
  {
    public static readonly ProjectListingStatus PUBLIC = new(nameof(PUBLIC).ToLower(), 0);
    public static readonly ProjectListingStatus UNLISTED = new(nameof(UNLISTED).ToLower(), 1);
    public static readonly ProjectListingStatus PRIVATE = new(nameof(PRIVATE).ToLower(), 2);

    protected ProjectListingStatus(string name, int value) : base(name, value) { }
  }
}

