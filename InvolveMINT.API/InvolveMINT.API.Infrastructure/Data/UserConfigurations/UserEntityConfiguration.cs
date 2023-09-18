using InvolveMINT.API.Core.UserAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InvolveMINT.API.Infrastructure.Data.UserConfigurations
{
  public class UserEntityConfiguration : IEntityTypeConfiguration<UserEntity>
  {
    public void Configure(EntityTypeBuilder<UserEntity> builder)
    {
      builder.HasKey(e => e.Id);

      builder.ToTable("User");

      builder.Property(e => e.Id)
        .HasColumnName("id")
        .HasColumnType("text")
      .HasConversion(
          id => id.ToString(),
          str => Guid.Parse(str)
      )
      .IsRequired();

      builder.Property(e => e.ActivationHash)
      .HasColumnType("character varying")
          .HasColumnName("activationHash");

      builder.Property(e => e.Active).HasColumnName("active");

      builder.Property(e => e.BaAdmin).HasColumnName("baAdmin");

      builder.Property(e => e.ChangeMakerId)
        .HasColumnName("changeMakerId")
        .HasColumnType("text")
        .HasConversion(
            id => id.ToString(),
            str => str == null ? null : Guid.Parse(str)
        );

      builder.Property(e => e.DateCreated)
          .HasDefaultValueSql("'2023-09-12 22:45:56.956236'::timestamp without time zone")
          .HasColumnType("timestamp without time zone")
          .HasColumnName("dateCreated");

      builder.Property(e => e.DateLastLoggedIn)
          .HasColumnType("timestamp without time zone")
          .HasColumnName("dateLastLoggedIn");

      builder.Property(e => e.ForgotPasswordHash)
          .HasColumnType("character varying")
          .HasColumnName("forgotPasswordHash");

      builder.Property(e => e.Joyride)
          .IsRequired()
      .HasDefaultValueSql("true")
          .HasColumnName("joyride");

      builder.Property(e => e.PasswordHash)
          .HasColumnType("character varying")
          .HasColumnName("passwordHash");

      builder.Property(e => e.Salt)
      .HasColumnType("character varying")
          .HasColumnName("salt");

    }
  }
}

