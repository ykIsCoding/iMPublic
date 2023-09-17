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

      builder.Property(e => e.Id)
          .HasColumnName("id")
          .HasColumnType("text")
          .HasConversion(
              id => id.ToString(),
              str => Guid.Parse(str)
          )
          .IsRequired();

      builder.Property(e => e.DateApplied).HasColumnName("dateApplied").IsRequired();
      builder.Property(e => e.DateSubmitted).HasColumnName("dateSubmitted");
      builder.Property(e => e.DateApproved).HasColumnName("dateApproved");
      builder.Property(e => e.DateDenied).HasColumnName("dateDenied");
      builder.Property(e => e.DateRetired).HasColumnName("dateRetired");
      builder.Property(e => e.AcceptedWaiver).HasColumnName("acceptedWaiver").HasDefaultValue(false);

      builder.Property(e => e.ProjectId)
        .HasColumnName("projectId")
        .HasColumnType("text")
        .HasConversion(
            id => id.ToString(),
            str => Guid.Parse(str)
        );

      builder.Property(e => e.ChangeMakerId)
        .HasColumnName("changeMakerId")
        .HasColumnType("text")
        .HasConversion(
            id => id.ToString(),
            str => Guid.Parse(str)
        );
    }
  }
}

