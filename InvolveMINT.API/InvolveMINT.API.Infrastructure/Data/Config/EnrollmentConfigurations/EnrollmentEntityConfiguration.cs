using InvolveMINT.API.Core.EnrollmentAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InvolveMINT.API.Infrastructure.Data.Config.EnrollmentConfigurations
{
  public class EnrollmentEntityConfiguration : IEntityTypeConfiguration<EnrollmentEntity>
  {
    public void Configure(EntityTypeBuilder<EnrollmentEntity> builder)
    {
      builder.ToTable("Enrollment");

      builder.HasKey(e => e.Id);

      builder.Property(e => e.Id)
          .HasColumnName("id")
          .HasColumnType("text")
          .HasConversion(
              id => id.ToString(),
              str => Guid.Parse(str)
        )
        .IsRequired();

        builder.Property(e => e.AcceptedWaiver).HasColumnName("acceptedWaiver");

        builder.Property(e => e.ChangeMakerId)
        .HasColumnName("changeMakerId")
        .HasColumnType("text")
        .HasConversion(
            id => id.ToString(),
            str => str == null ? null : Guid.Parse(str)
        );

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
        .HasColumnType("text")
        .HasConversion(
            id => id.ToString(),
            str => str == null ? null : Guid.Parse(str)
        );
    }
  }
}

