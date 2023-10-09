using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using InvolveMINT.API.Core.UserAggregate;

namespace InvolveMINT.API.Infrastructure.Data.Config.UserConfigurations
{
  public class ExchangePartnerApplicationEntityConfiguration : IEntityTypeConfiguration<ExchangePartnerApplicationEntity>
  {
    public void Configure(EntityTypeBuilder<ExchangePartnerApplicationEntity> builder)
    {
      builder.HasKey(e => e.Id);

      builder.ToTable("EpApplication");

      builder.Property(e => e.Id)
        .HasColumnName("id")
        .HasColumnType("text")
        .IsRequired();

      builder.Property(e => e.AddressId)
        .HasColumnName("addressId")
        .HasColumnType("text");

      builder.Property(e => e.DateCreated)
          .HasDefaultValueSql("'2023-09-12 22:45:56.956236'::timestamp without time zone")
          .HasColumnType("timestamp without time zone")
          .HasColumnName("dateCreated");

      builder.Property(e => e.Ein)
          .HasColumnType("character varying")
          .HasColumnName("ein");

      builder.Property(e => e.Email)
      .HasColumnType("character varying")
          .HasColumnName("email");

      builder.Property(e => e.HandleId)
        .HasColumnName("handleId")
        .HasColumnType("text");

      builder.Property(e => e.Name)
          .HasColumnType("character varying")
          .HasColumnName("name");

      builder.Property(e => e.Phone)
      .HasColumnType("character varying")
          .HasColumnName("phone");

      builder.Property(e => e.UserId)
        .HasColumnName("userId")
        .HasColumnType("text");

      builder.Property(e => e.Website)
          .HasColumnType("character varying")
          .HasColumnName("website");
    }
  }
}

