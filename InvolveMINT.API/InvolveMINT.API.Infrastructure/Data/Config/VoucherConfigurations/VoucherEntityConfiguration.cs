using InvolveMINT.API.Core.VoucherAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InvolveMINT.API.Infrastructure.Data.Config.VoucherConfigurations
{
  public class VoucherEntityConfiguration : IEntityTypeConfiguration<VoucherEntity>
  {
    public void Configure(EntityTypeBuilder<VoucherEntity> builder)
    {
      builder.HasKey(e => e.Id);

      builder.ToTable("Voucher");

      builder.Property(e => e.Id)
        .HasColumnName("id")
        .HasColumnType("text")
        .IsRequired();


      builder.Property(e => e.Amount).HasColumnName("amount");

      builder.Property(e => e.BuyerId)
        .HasColumnName("buyerId")
        .HasColumnType("text");

      builder.Property(e => e.ChangeMakerReceiverId)
        .HasColumnName("changeMakerReceiverId")
        .HasColumnType("text");

      builder.Property(e => e.Code)
          .HasColumnType("character varying")
          .HasColumnName("code");

      builder.Property(e => e.DateArchived)
          .HasColumnType("timestamp without time zone")
          .HasColumnName("dateArchived");

      builder.Property(e => e.DateCreated)
          .HasColumnType("timestamp without time zone")
          .HasColumnName("dateCreated");

      builder.Property(e => e.DateExpires)
          .HasColumnType("timestamp without time zone")
          .HasColumnName("dateExpires");

      builder.Property(e => e.DateRedeemed)
          .HasColumnType("timestamp without time zone")
          .HasColumnName("dateRedeemed");

      builder.Property(e => e.DateRefunded)
          .HasColumnType("timestamp without time zone")
          .HasColumnName("dateRefunded");

      builder.Property(e => e.ExchangePartnerReceiverId)
        .HasColumnName("exchangePartnerReceiverId")
        .HasColumnType("text");

      builder.Property(e => e.SellerId)
        .HasColumnName("sellerId")
        .HasColumnType("text");

      builder.Property(e => e.ServePartnerReceiverId)
        .HasColumnName("servePartnerReceiverId")
        .HasColumnType("text");
    }
  }
}

