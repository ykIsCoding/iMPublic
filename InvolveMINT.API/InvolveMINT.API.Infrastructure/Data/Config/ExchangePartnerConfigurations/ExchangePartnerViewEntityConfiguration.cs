using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using InvolveMINT.API.Core.ExchangePartnerAggregate;

namespace InvolveMINT.API.Infrastructure.Data.Config.ExchangePartnerConfigurations
{
  public class ExchangePartnerViewEntityConfiguration : IEntityTypeConfiguration<ExchangePartnerViewEntity>
  {
    public void Configure(EntityTypeBuilder<ExchangePartnerViewEntity> builder)
    {
      builder
        .HasNoKey()
        .ToView("exchange_partner_view_entity");

      builder.Property(e => e.Id)
        .HasColumnName("id")
        .HasColumnType("text")
        .HasConversion(
            id => id.ToString(),
            str => str == null ? null : Guid.Parse(str)
        );
      builder.Property(e => e.ReceivedThisMonth).HasColumnName("receivedThisMonth");
    }
  }
}

