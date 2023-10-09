using InvolveMINT.API.SharedKernel;

namespace InvolveMINT.API.Core.ProjectAggregate
{
  public class ProjectEntity : EntityBase<string>, IAggregateRoot
  {
    public ProjectEntity()
    {
    }

    public string Description { get; set; } = null!;

    public ProjectListingStatus ListingStatus { get; set; } = ProjectListingStatus.PRIVATE;

    public string Title { get; set; } = null!;

    public string City { get; set; } = null!;

    public string State { get; set; } = null!;

    public string[] ImagesFilePaths { get; set; } = null!;

    public int CreditsEarned { get; set; }

    public string PreferredScheduleOfWork { get; set; } = null!;

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public bool? RequireLocation { get; set; }

    public bool? RequireImages { get; set; }

    public int MaxChangeMakers { get; set; }

    public DateTime DateCreated { get; set; }

    public DateTime DateUpdated { get; set; }

    public bool RequireCustomWaiver { get; set; }

    public string? CustomWaiverFilePath { get; set; }

    public string AddressId { get; set; }

    public string? ServePartnerId { get; set; }
  }
}

