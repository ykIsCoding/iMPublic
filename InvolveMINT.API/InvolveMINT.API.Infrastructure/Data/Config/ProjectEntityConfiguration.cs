using InvolveMINT.API.Core.ProjectAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InvolveMINT.API.Infrastructure.Data.Config
{
  public class ProjectEntityConfiguration : IEntityTypeConfiguration<ProjectEntity>
  {
    public void Configure(EntityTypeBuilder<ProjectEntity> builder)
    {
      builder.HasKey(e => e.Id);

      builder.ToTable("Project");

      builder.Property(e => e.Id)
        .HasColumnName("id")
        .HasColumnType("text")
        .HasConversion(
            id => id.ToString(),
            str => Guid.Parse(str)
        )
        .IsRequired();

      builder.Property(e => e.AddressId)
        .HasColumnName("addressId")
        .HasColumnType("text")
        .HasConversion(
            id => id.ToString(),
            str => Guid.Parse(str)
        );

      builder.Property(e => e.City)
          .HasDefaultValueSql("''::character varying")
          .HasColumnType("character varying")
          .HasColumnName("city");

      builder.Property(e => e.CreditsEarned)
          .HasDefaultValueSql("12000")
          .HasColumnName("creditsEarned");

      builder.Property(e => e.CustomWaiverFilePath)
          .HasColumnType("character varying")
          .HasColumnName("customWaiverFilePath");

      builder.Property(e => e.DateCreated)
          .HasDefaultValueSql("'2023-09-12 22:45:56.956236'::timestamp without time zone")
          .HasColumnType("timestamp without time zone")
          .HasColumnName("dateCreated");

      builder.Property(e => e.DateUpdated)
          .HasDefaultValueSql("'2023-09-12 22:45:56.956236'::timestamp without time zone")
          .HasColumnType("timestamp without time zone")
          .HasColumnName("dateUpdated");

      builder.Property(e => e.Description)
          .HasColumnType("character varying")
          .HasColumnName("description");

      builder.Property(e => e.EndDate)
          .HasColumnType("timestamp without time zone")
          .HasColumnName("endDate");

      builder.Property(e => e.ImagesFilePaths)
          .HasDefaultValueSql("'{}'::text[]")
          .HasColumnName("imagesFilePaths");

      builder.Property(e => e.ListingStatus)
          .HasDefaultValueSql("'private'::text")
          .HasColumnName("listingStatus")
          .HasConversion(
            x => x.Value,
            x => ProjectListingStatus.FromValue(x))
          .IsRequired(); ;

      builder.Property(e => e.MaxChangeMakers)
          .HasDefaultValueSql("5")
          .HasColumnName("maxChangeMakers");

      builder.Property(e => e.PreferredScheduleOfWork)
          .HasDefaultValueSql("''::character varying")
          .HasColumnType("character varying")
          .HasColumnName("preferredScheduleOfWork");

      builder.Property(e => e.RequireCustomWaiver).HasColumnName("requireCustomWaiver");

      builder.Property(e => e.RequireImages)
          .IsRequired()
          .HasDefaultValueSql("true")
          .HasColumnName("requireImages");

      builder.Property(e => e.RequireLocation)
          .IsRequired()
          .HasDefaultValueSql("true")
          .HasColumnName("requireLocation");

      builder.Property(e => e.ServePartnerId)
        .HasColumnName("servePartnerId")
        .HasColumnType("text")
        .HasConversion(
            id => id.ToString(),
            str => str == null ? null : Guid.Parse(str)
        );

      builder.Property(e => e.StartDate)
          .HasColumnType("timestamp without time zone")
          .HasColumnName("startDate");

      builder.Property(e => e.State)
          .HasDefaultValueSql("''::character varying")
          .HasColumnType("character varying")
          .HasColumnName("state");

      builder.Property(e => e.Title)
          .HasColumnType("character varying")
          .HasColumnName("title");

    }
  }
}

