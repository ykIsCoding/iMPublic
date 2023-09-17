using InvolveMINT.API.Core.ChangeMakerAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InvolveMINT.API.Infrastructure.Data.Config
{
  public class ChangeMakerEntityConfiguration : IEntityTypeConfiguration<ChangeMakerEntity>
  {
    public void Configure(EntityTypeBuilder<ChangeMakerEntity> builder)
    {
      builder.ToTable("ChangeMaker");

      // Configure the Id property to use a text column and Guid conversion
      builder.Property(e => e.Id)
          .HasColumnName("id")
          .HasColumnType("text")
          .HasConversion(
              id => id.ToString(),
              str => Guid.Parse(str)
          )
          .IsRequired();

      builder.Property(e => e.FirstName).HasColumnName("firstName").IsRequired();
      builder.Property(e => e.LastName).HasColumnName("lastName").IsRequired();
      builder.Property(e => e.ProfilePicFilePath).HasColumnName("profilePicFilePath");
      builder.Property(e => e.Bio).HasColumnName("bio");
      builder.Property(e => e.Phone).HasColumnName("phone").IsRequired();
      builder.Property(e => e.OnboardingState).HasColumnName("onboardingState")
        .HasConversion(
          x => x.Value,
          x => ChangeMakerOnboardingState.FromValue(x))
        .IsRequired();
      builder.Property(e => e.DateCreated).HasColumnName("dateCreated").HasDefaultValueSql("NOW()");

      builder.Property(e => e.HandleId).HasColumnName("handleId")
        .HasColumnType("text")
        .HasConversion(
            id => id.ToString(),
            str => Guid.Parse(str)
        );

      builder.Property(e => e.AddressId).HasColumnName("addressId")
        .HasColumnType("text")
        .HasConversion(
            id => id.ToString(),
            str => Guid.Parse(str)
        );
    }
  }
}

