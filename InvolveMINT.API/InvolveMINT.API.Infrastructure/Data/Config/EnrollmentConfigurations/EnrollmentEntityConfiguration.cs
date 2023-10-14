using InvolveMINT.API.Core.Aggregates.Enrollments;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InvolveMINT.API.Infrastructure.Data.Config.EnrollmentConfigurations
{
  public class EnrollmentConfiguration : IEntityTypeConfiguration<Enrollment>
  {
    public void Configure(EntityTypeBuilder<Enrollment> builder)
    {
      builder.ToTable("Enrollment");

      builder.HasKey(e => e.Id);

      builder.Property(e => e.Id)
          .HasColumnName("id")
          .HasColumnType("text")
        .IsRequired();

        builder.Property(e => e.AcceptedWaiver).HasColumnName("acceptedWaiver");

        builder.Property(e => e.ChangeMakerId)
        .HasColumnName("changeMakerId")
        .HasColumnType("text");

        builder.Property(e => e.DateApplied)
            .HasColumnType("timestamp without time zone")
            .HasColumnName("dateApplied");

        builder.Property(e => e.DateApproved)
            .HasColumnType("timestamp without time zone")
            .HasColumnName("dateApproved");

        builder.Property(e => e.DateDenied)
            .HasColumnType("timestamp without time zone")
            .HasColumnName("dateDenied");

        builder.Property(e => e.DateRetired)
            .HasColumnType("timestamp without time zone")
            .HasColumnName("dateRetired");

        builder.Property(e => e.DateSubmitted)
            .HasColumnType("timestamp without time zone")
            .HasColumnName("dateSubmitted");

        builder.Property(e => e.ProjectId)
        .HasColumnName("projectId")
        .HasColumnType("text");

      builder.HasMany(x => x.EnrollmentDocuments)
      .WithOne()
      .HasForeignKey(x => x.EnrollmentId);

      builder.Navigation(e => e.EnrollmentDocuments).AutoInclude();

      builder.HasMany(x => x.POIs)
      .WithOne()
      .HasForeignKey(x => x.EnrollmentId);

      builder.Navigation(e => e.POIs).AutoInclude();
    }
  }
}

