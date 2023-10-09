using InvolveMINT.API.Core.ServePartnerAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InvolveMINT.API.Infrastructure.Data.Config.ServePartnerConfigurations
{
  public class ServePartnerEntityConfiguration : IEntityTypeConfiguration<ServePartnerEntity>
  {
    public void Configure(EntityTypeBuilder<ServePartnerEntity> builder)
    {
      builder.HasKey(e => e.Id);

      builder.ToTable("ServePartner");

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

      builder.Property(e => e.Description)
          .HasColumnType("character varying")
          .HasColumnName("description");

      builder.Property(e => e.Email)
        .HasColumnType("character varying")
        .HasColumnName("email");

      builder.Property(e => e.HandleId)
        .HasColumnName("handleId")
        .HasColumnType("text");

      builder.Property(e => e.ImagesFilePaths)
          .HasDefaultValueSql("'{}'::text[]")
          .HasColumnName("imagesFilePaths");

      builder.Property(e => e.Latitude)
        .HasColumnName("latitude");

      builder.Property(e => e.LogoFilePath)
          .HasColumnType("character varying")
          .HasColumnName("logoFilePath");

      builder.Property(e => e.Longitude)
        .HasColumnName("longitude");

      builder.Property(e => e.Name)
          .HasColumnType("character varying")
          .HasColumnName("name");

      builder.Property(e => e.Phone)
          .HasColumnType("character varying")
          .HasColumnName("phone");

      builder.Property(e => e.Website)
        .HasColumnType("character varying")
        .HasColumnName("website");
    }
  }
}

