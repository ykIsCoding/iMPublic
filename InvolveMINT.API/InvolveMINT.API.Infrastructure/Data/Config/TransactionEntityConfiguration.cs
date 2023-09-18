using Ardalis.Specification;
using InvolveMINT.API.Core.TransactionAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InvolveMINT.API.Infrastructure.Data.Config
{
  public class TransactionEntityConfiguration : IEntityTypeConfiguration<TransactionEntity>
  {
    public void Configure(EntityTypeBuilder<TransactionEntity> builder)
    {
      builder.HasKey(e => e.Id);

      builder.ToTable("Transaction");

      builder.Property(e => e.Id)
        .HasColumnName("id")
        .HasColumnType("text")
        .HasConversion(
            id => id.ToString(),
            str => Guid.Parse(str)
        )
        .IsRequired();

      builder.Property(e => e.Amount).HasColumnName("amount");

      builder.Property(e => e.DateTransacted)
          .HasColumnType("timestamp without time zone")
          .HasColumnName("dateTransacted");

      builder.Property(e => e.EpAudibleCode)
          .HasColumnType("character varying")
          .HasColumnName("epAudibleCode");

      builder.Property(e => e.Memo)
          .HasColumnType("character varying")
          .HasColumnName("memo");

      builder.Property(e => e.ReceiverChangeMakerId)
        .HasColumnName("receiverChangeMakerId")
        .HasColumnType("text")
        .HasConversion(
            id => id.ToString(),
            str => str == null ? null : Guid.Parse(str)
        );

      builder.Property(e => e.ReceiverExchangePartnerId)
        .HasColumnName("receiverExchangePartnerId")
        .HasColumnType("text")
        .HasConversion(
            id => id.ToString(),
            str => str == null ? null : Guid.Parse(str)
        );

      builder.Property(e => e.ReceiverServePartnerId)
        .HasColumnName("receiverServePartnerId")
        .HasColumnType("text")
        .HasConversion(
            id => id.ToString(),
            str => str == null ? null : Guid.Parse(str)
        );

      builder.Property(e => e.SenderChangeMakerId)
        .HasColumnName("senderChangeMakerId")
        .HasColumnType("text")
        .HasConversion(
            id => id.ToString(),
            str => str == null ? null : Guid.Parse(str)
        );

      builder.Property(e => e.SenderExchangePartnerId)
        .HasColumnName("senderExchangePartnerId")
        .HasColumnType("text")
        .HasConversion(
            id => id.ToString(),
            str => str == null ? null : Guid.Parse(str)
        );

      builder.Property(e => e.SenderServePartnerId)
        .HasColumnName("senderServePartnerId")
        .HasColumnType("text")
        .HasConversion(
            id => id.ToString(),
            str => str == null ? null : Guid.Parse(str)
        );
    }
  }
}

