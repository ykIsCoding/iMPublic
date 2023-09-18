using InvolveMINT.API.Core.ProofOfImpactAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InvolveMINT.API.Infrastructure.Data.Config.ProofOfImpactConfigurations
{
  public class ProofOfImpactEntityConfiguration : IEntityTypeConfiguration<ProofOfImpactEntity>
  {
    public void Configure(EntityTypeBuilder<ProofOfImpactEntity> builder)
    {
      builder.HasKey(e => e.Id);

      builder.ToTable("Poi");

      builder.Property(e => e.Id)
        .HasColumnName("id")
        .HasColumnType("text")
        .HasConversion(
            id => id.ToString(),
            str => Guid.Parse(str)
        )
        .IsRequired();

      builder.Property(e => e.DateApproved)
          .HasColumnType("timestamp without time zone")
          .HasColumnName("dateApproved");

      builder.Property(e => e.DateCreated)
          .HasDefaultValueSql("'2023-09-12 22:45:56.956236'::timestamp without time zone")
          .HasColumnType("timestamp without time zone")
          .HasColumnName("dateCreated");

      builder.Property(e => e.DateDenied)
          .HasColumnType("timestamp without time zone")
          .HasColumnName("dateDenied");

      builder.Property(e => e.DateStarted)
          .HasColumnType("timestamp without time zone")
          .HasColumnName("dateStarted");

      builder.Property(e => e.DateStopped)
          .HasColumnType("timestamp without time zone")
          .HasColumnName("dateStopped");

      builder.Property(e => e.DateSubmitted)
          .HasColumnType("timestamp without time zone")
          .HasColumnName("dateSubmitted");

      builder.Property(e => e.EnrollmentId)
        .HasColumnName("enrollmentId")
        .HasColumnType("text")
        .HasConversion(
            id => id.ToString(),
            str => str == null ? null : Guid.Parse(str)
        );

      builder.Property(e => e.ImagesFilePaths)
          .HasDefaultValueSql("'{}'::text[]")
          .HasColumnName("imagesFilePaths");

      builder.Property(e => e.Latitude).HasColumnName("latitude");

      builder.Property(e => e.Longitude).HasColumnName("longitude");

      builder.Property(e => e.PausedTimes).HasColumnName("pausedTimes");

      builder.Property(e => e.ResumedTimes).HasColumnName("resumedTimes");
    }
  }
}

