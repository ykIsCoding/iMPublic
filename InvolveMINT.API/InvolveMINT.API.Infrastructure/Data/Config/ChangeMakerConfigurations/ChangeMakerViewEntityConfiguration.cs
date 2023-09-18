using InvolveMINT.API.Core.ChangeMakerAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InvolveMINT.API.Infrastructure.Data.Config.ChangeMakerConfigurations
{
  public class ChangeMakerViewEntityConfiguration : IEntityTypeConfiguration<ChangeMakerViewEntity>
  {
    public void Configure(EntityTypeBuilder<ChangeMakerViewEntity> builder)
    {
      builder
        .HasNoKey()
        .ToView("change_maker_view_entity");

      builder.Property(e => e.EarnedCredits).HasColumnName("earnedCredits");
      builder.Property(e => e.Id)
        .HasColumnName("id")
        .HasColumnType("text")
        .HasConversion(
            id => id.ToString(),
            str => str == null ? null : Guid.Parse(str)
        );
      builder.Property(e => e.PoiApproved).HasColumnName("poiApproved");
      builder.Property(e => e.SecondsCompleted).HasColumnName("secondsCompleted");
      builder.Property(e => e.SpentCredits).HasColumnName("spentCredits");
    }
  }
}

