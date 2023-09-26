using InvolveMINT.API.Core.ChangeMakerAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InvolveMINT.API.Infrastructure.Data.Config.ChangeMakerConfigurations;

public class ChangeMakerEntityConfiguration : IEntityTypeConfiguration<ChangeMakerEntity>
{
  public void Configure(EntityTypeBuilder<ChangeMakerEntity> builder)
  {
    builder.ToTable("ChangeMaker");

    builder.HasKey(e => e.Id);

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

    builder.Property(e => e.Bio)
    .HasColumnType("character varying")
    .HasColumnName("bio");

    builder.Property(e => e.DateCreated)
        .HasDefaultValueSql("'2023-09-12 22:45:56.956236'::timestamp without time zone")
        .HasColumnType("timestamp without time zone")
        .HasColumnName("dateCreated");

    builder.Property(e => e.FirstName)
        .HasColumnType("character varying")
        .HasColumnName("firstName");

    builder.Property(e => e.HandleId)
      .HasColumnName("handleId")
      .HasColumnType("text")
      .HasConversion(
          id => id.ToString(),
          str => str == null ? null : Guid.Parse(str)
      );

    builder.Property(e => e.LastName)
        .HasColumnType("character varying")
        .HasColumnName("lastName");

    builder.Property(e => e.OnboardingState)
      .HasColumnName("onboardingState")
      .HasConversion(
        x => x.Name,
        x => ChangeMakerOnboardingState.FromName(x, true))
      .IsRequired();

    builder.Property(e => e.Phone)
        .HasColumnType("character varying")
        .HasColumnName("phone");

    builder.Property(e => e.ProfilePicFilePath)
        .HasColumnType("character varying")
        .HasColumnName("profilePicFilePath");

  }
}

