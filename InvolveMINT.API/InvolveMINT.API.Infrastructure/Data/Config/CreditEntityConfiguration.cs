using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using InvolveMINT.API.Core.Aggregates.Credits;

namespace InvolveMINT.API.Infrastructure.Data.Config
{
  public class CreditConfiguration : IEntityTypeConfiguration<Credit>
  {
    public void Configure(EntityTypeBuilder<Credit> builder)
    {
      builder.ToTable("Credit");

      builder.HasKey(e => e.Id);

      builder.Property(e => e.Id)
        .HasColumnName("id")
        .HasColumnType("text")
        .IsRequired();

      builder.Property(e => e.Amount).HasColumnName("amount");

      builder.Property(e => e.ChangeMakerId)
        .HasColumnName("changeMakerId")
        .HasColumnType("text");

      builder.Property(e => e.DateMinted)
          .HasColumnType("timestamp without time zone")
          .HasColumnName("dateMinted");

      builder.Property(e => e.Escrow).HasColumnName("escrow");

      builder.Property(e => e.ExchangePartnerId)
        .HasColumnName("exchangePartnerId")
        .HasColumnType("text");

      builder.Property(e => e.PoiId)
        .HasColumnName("poiId")
        .HasColumnType("text");

      builder.Property(e => e.ServePartnerId)
        .HasColumnName("servePartnerId")
        .HasColumnType("text");
    }
  }
}

