using InvolveMINT.API.Core.ServePartnerAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InvolveMINT.API.Infrastructure.Data.Config.ServePartnerConfigurations
{
  public class ServeAdminEntityConfiguration : IEntityTypeConfiguration<ServeAdminEntity>
  {
    public void Configure(EntityTypeBuilder<ServeAdminEntity> builder)
    {
      builder.HasKey(e => e.Id);

      builder.ToTable("ServeAdmin");

      builder.Property(e => e.Id)
        .HasColumnName("id")
        .HasColumnType("text")
        .IsRequired();

      builder.Property(e => e.DatePermitted)
        .HasColumnType("timestamp without time zone")
        .HasColumnName("datePermitted");

      builder.Property(e => e.ServePartnerId)
        .HasColumnName("servePartnerId")
        .HasColumnType("text");

      builder.Property(e => e.SuperAdmin)
        .HasColumnName("superAdmin");

      builder.Property(e => e.UserId)
        .HasColumnName("userId")
        .HasColumnType("text");
    }
  }
}

