using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using InvolveMINT.API.Core.Aggregates.ExchangePartners;

namespace InvolveMINT.API.Infrastructure.Data.Config.ExchangePartnerConfigurations
{
  public class ExchangeAdminConfiguration : IEntityTypeConfiguration<ExchangeAdmin>
  {
    public void Configure(EntityTypeBuilder<ExchangeAdmin> builder)
    {
      builder.HasKey(e => e.Id);

      builder.ToTable("ExchangeAdmin");

      builder.Property(e => e.Id)
        .HasColumnName("id")
        .HasColumnType("text")
        .IsRequired();

      builder.Property(e => e.DatePermitted)
        .HasColumnType("timestamp without time zone")
        .HasColumnName("datePermitted");

      builder.Property(e => e.ExchangePartnerId)
        .HasColumnName("exchangePartnerId")
        .HasColumnType("text");

      builder.Property(e => e.SuperAdmin).HasColumnName("superAdmin");

      builder.Property(e => e.UserId)
        .HasColumnName("userId")
        .HasColumnType("text");

    }
  }
}

