using InvolveMINT.API.Core.UserAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InvolveMINT.API.Infrastructure.Data.Config.UserConfigurations
{
  public class ServePartnerApplicationEntityConfiguration : IEntityTypeConfiguration<ServePartnerApplicationEntity>
  {
    public void Configure(EntityTypeBuilder<ServePartnerApplicationEntity> builder)
    {
      builder.HasKey(e => e.Id);

      builder.ToTable("SpApplication");

      builder.Property(e => e.Id)
        .HasColumnName("id")
        .HasColumnType("text")
        .HasConversion(
            id => id.ToString(),
            str => Guid.Parse(str)
        )
        .IsRequired();

      builder.Property(e => e.AddressId)
        .HasColumnName("addressId")
        .HasColumnType("text")
        .HasConversion(
            id => id.ToString(),
            str => str == null ? null : Guid.Parse(str)
        );

      builder.Property(e => e.DateCreated)
          .HasDefaultValueSql("'2023-09-12 22:45:56.956236'::timestamp without time zone")
          .HasColumnType("timestamp without time zone")
          .HasColumnName("dateCreated");

      builder.Property(e => e.Email)
      .HasColumnType("character varying")
          .HasColumnName("email");

      builder.Property(e => e.HandleId)
        .HasColumnName("handleId")
        .HasColumnType("text")
        .HasConversion(
            id => id.ToString(),
            str => str == null ? null : Guid.Parse(str)
        );

      builder.Property(e => e.Name)
          .HasColumnType("character varying")
          .HasColumnName("name");

      builder.Property(e => e.Phone)
      .HasColumnType("character varying")
          .HasColumnName("phone");

      builder.Property(e => e.UserId)
        .HasColumnName("userId")
        .HasColumnType("text")
        .HasConversion(
            id => id.ToString(),
            str => str == null ? null : Guid.Parse(str)
        );

      builder.Property(e => e.Website)
          .HasColumnType("character varying")
          .HasColumnName("website");
    }
  }
}

