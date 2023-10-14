using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using InvolveMINT.API.Core.Aggregates.Offers;

namespace InvolveMINT.API.Infrastructure.Data.Config
{
  public class OfferConfiguration : IEntityTypeConfiguration<Offer>
  {
    public void Configure(EntityTypeBuilder<Offer> builder)
    {
      builder.HasKey(e => e.Id);
      builder.ToTable("Offer");

      builder.Property(e => e.Id)
        .HasColumnName("id")
        .HasColumnType("text")
        .IsRequired(); ;

      builder.Property(e => e.ChangeMakerId)
        .HasColumnName("changeMakerId")
        .HasColumnType("text");

      builder.Property(e => e.DateCreated)
          .HasDefaultValueSql("'2023-09-12 22:45:56.956236'::timestamp without time zone")
          .HasColumnType("timestamp without time zone")
          .HasColumnName("dateCreated");

      builder.Property(e => e.DateUpdated)
          .HasDefaultValueSql("'2023-09-12 22:45:56.956236'::timestamp without time zone")
          .HasColumnType("timestamp without time zone")
          .HasColumnName("dateUpdated");

      builder.Property(e => e.Description)
          .HasColumnType("character varying")
          .HasColumnName("description");

      builder.Property(e => e.ExchangePartnerId)
        .HasColumnName("exchangePartnerId")
        .HasColumnType("text");

      builder.Property(e => e.ImagesFilePaths)
          .HasDefaultValueSql("'{}'::text[]")
          .HasColumnName("imagesFilePaths");

      builder.Property(e => e.ListingStatus)
        .HasColumnType("text")
        .HasDefaultValueSql("'private'::text")
        .HasColumnName("listingStatus")
        .HasConversion(
          x => x.Name,
          x => OfferListingStatus.FromName(x, true))
        .IsRequired();

      builder.Property(e => e.Name)
          .HasColumnType("character varying")
          .HasColumnName("name");

      builder.Property(e => e.Price).HasColumnName("price");

      builder.Property(e => e.ServePartnerId)
        .HasColumnName("servePartnerId")
        .HasColumnType("text");
    }
  }
}

