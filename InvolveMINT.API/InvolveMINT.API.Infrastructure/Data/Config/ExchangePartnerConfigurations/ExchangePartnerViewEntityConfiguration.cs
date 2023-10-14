using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using InvolveMINT.API.Core.Aggregates.ExchangePartners;

namespace InvolveMINT.API.Infrastructure.Data.Config.ExchangePartnerConfigurations
{
  public class ExchangePartnerViewConfiguration : IEntityTypeConfiguration<ExchangePartnerView>
  {
    public void Configure(EntityTypeBuilder<ExchangePartnerView> builder)
    {
      builder
        .HasNoKey()
        .ToView("exchange_partner_view_entity");

      builder.Property(e => e.Id)
        .HasColumnName("id")
        .HasColumnType("text");
      builder.Property(e => e.ReceivedThisMonth).HasColumnName("receivedThisMonth");
    }
  }
}

