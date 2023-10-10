using Ardalis.Specification;
using InvolveMINT.API.Core.EnrollmentAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InvolveMINT.API.Infrastructure.Data.Config.ProofOfImpactConfigurations
{
  public class TaskEntityConfiguration : IEntityTypeConfiguration<TaskEntity>
  {
    public void Configure(EntityTypeBuilder<TaskEntity> builder)
    {
      builder.HasKey(e => e.Id);

      builder.ToTable("Task");

      builder.Property(e => e.Id)
        .HasColumnName("id")
        .HasColumnType("text")
        .IsRequired();

      builder.Property(e => e.PoiId)
        .HasColumnName("poiId")
        .HasColumnType("text")
        .IsRequired();

    }
  }
}

