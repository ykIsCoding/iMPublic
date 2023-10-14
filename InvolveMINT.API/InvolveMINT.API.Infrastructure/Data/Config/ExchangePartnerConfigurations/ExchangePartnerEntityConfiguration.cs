using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using InvolveMINT.API.Core.Aggregates.ExchangePartners;

namespace InvolveMINT.API.Infrastructure.Data.Config.ExchangePartnerConfigurations
{
  public class ExchangePartnerConfiguration : IEntityTypeConfiguration<ExchangePartner>
  {
    public void Configure(EntityTypeBuilder<ExchangePartner> builder)
    {
      builder.HasKey(e => e.Id);
      builder.ToTable("ExchangePartner");

      builder.Property(e => e.Id)
        .HasColumnName("id")
        .HasColumnType("text")
        .IsRequired(); ;

      builder.Property(e => e.AddressId)
        .HasColumnName("addressId")
        .HasColumnType("text");

      builder.Property(e => e.Budget).HasColumnName("budget");

      builder.Property(e => e.BudgetEndDate)
        .HasColumnType("timestamp without time zone")
        .HasColumnName("budgetEndDate");

      builder.Property(e => e.DateCreated)
        .HasDefaultValueSql("'2023-09-12 22:45:56.956236'::timestamp without time zone")
        .HasColumnType("timestamp without time zone")
        .HasColumnName("dateCreated");

      builder.Property(e => e.Description)
        .HasColumnType("character varying")
        .HasColumnName("description");

      builder.Property(e => e.Ein)
        .HasColumnType("character varying")
        .HasColumnName("ein");

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
      builder.Property(e => e.ListStoreFront)
          .HasDefaultValueSql("'public'::text")
          .HasColumnName("listStoreFront");

      builder.Property(e => e.LogoFilePath)
          .HasColumnType("character varying")
          .HasColumnName("logoFilePath");

      builder.Property(e => e.Longitude)
        .HasColumnName("longitude");

      builder.Property(e => e.Name)
      .HasColumnType("character varying")
          .HasColumnName("name");

      builder.Property(e => e.OnboardingState)
          .HasDefaultValueSql("'profile'::text")
          .HasColumnName("onboardingState")
          .HasConversion(
            x => x.Name,
            x => ExchangePartnerOnboardingState.FromName(x, true))
          .IsRequired();

      builder.Property(e => e.Phone)
        .HasColumnType("character varying")
        .HasColumnName("phone");

      builder.Property(e => e.Website)
        .HasColumnType("character varying")
        .HasColumnName("website");

      builder.HasOne(x => x.ExchangeAdmin)
        .WithOne()
        .HasForeignKey<ExchangeAdmin>(x => x.ExchangePartnerId);
    }
  }
}

