using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using InvolveMINT.API.Core.HandleAggregate;

namespace InvolveMINT.API.Infrastructure.Data.Config
{
  public class HandleEntityConfiguration : IEntityTypeConfiguration<HandleEntity>
  {
    public void Configure(EntityTypeBuilder<HandleEntity> builder)
    {
      builder.HasKey(e => e.Id);
      builder.ToTable("Handle");

      builder.Property(e => e.Id)
        .HasColumnName("id")
        .IsRequired();
    }
  }
}

