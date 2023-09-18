using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using InvolveMINT.API.Core.CreditAggregate;

namespace InvolveMINT.API.Infrastructure.Data.Config
{
  public class CreditEntityConfiguration : IEntityTypeConfiguration<CreditEntity>
  {
    public void Configure(EntityTypeBuilder<CreditEntity> builder)
    {
      builder.ToTable("Credit");

      builder.HasKey(e => e.Id);

      builder.Property(e => e.Id)
        .HasColumnName("id")
        .HasColumnType("text")
        .HasConversion(
            id => id.ToString(),
            str => Guid.Parse(str)
        )
        .IsRequired();

      builder.Property(e => e.Amount).HasColumnName("amount");

      builder.Property(e => e.ChangeMakerId)
        .HasColumnName("changeMakerId")
        .HasColumnType("text")
        .HasConversion(
            id => id.ToString(),
            str => str == null ? null : Guid.Parse(str)
        );

      builder.Property(e => e.DateMinted)
          .HasColumnType("timestamp without time zone")
          .HasColumnName("dateMinted");

      builder.Property(e => e.Escrow).HasColumnName("escrow");

      builder.Property(e => e.ExchangePartnerId)
        .HasColumnName("exchangePartnerId")
        .HasColumnType("text")
        .HasConversion(
            id => id.ToString(),
            str => str == null ? null : Guid.Parse(str)
        );

      builder.Property(e => e.PoiId)
        .HasColumnName("poiId")
        .HasColumnType("text")
        .HasConversion(
            id => id.ToString(),
            str => str == null ? null : Guid.Parse(str)
        );

      builder.Property(e => e.ServePartnerId)
        .HasColumnName("servePartnerId")
        .HasColumnType("text")
        .HasConversion(
            id => id.ToString(),
            str => str == null ? null : Guid.Parse(str)
        );
    }
  }
}

