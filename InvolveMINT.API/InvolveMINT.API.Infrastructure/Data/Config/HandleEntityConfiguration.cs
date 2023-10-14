using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using InvolveMINT.API.Core.Aggregates.Handles;

namespace InvolveMINT.API.Infrastructure.Data.Config
{
  public class HandleConfiguration : IEntityTypeConfiguration<Handle>
  {
    public void Configure(EntityTypeBuilder<Handle> builder)
    {
      builder.HasKey(e => e.Id);
      builder.ToTable("Handle");

      builder.Property(e => e.Id)
        .HasColumnName("id")
        .IsRequired();
    }
  }
}

