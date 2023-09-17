using InvolveMINT.API.Core.UserAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InvolveMINT.API.Infrastructure.Data.Config
{
  public class UserEntityConfiguration : IEntityTypeConfiguration<UserEntity>
  {
    public void Configure(EntityTypeBuilder<UserEntity> builder)
    {
      builder.ToTable("User");

      // Configure the Id property to use a text column and Guid conversion
      builder.Property(e => e.Id)
          .HasColumnName("id")
          .HasColumnType("text")
          .HasConversion(
              id => id.ToString(),
              str => Guid.Parse(str)
          )
          .IsRequired();

      builder.Property(e => e.PasswordHash).HasColumnName("passwordHash").IsRequired();
      builder.Property(e => e.Salt).HasColumnName("salt").IsRequired();
      builder.Property(e => e.DateCreated).HasColumnName("dateCreated").HasDefaultValueSql("NOW()");
      builder.Property(e => e.DateLastLoggedIn).HasColumnName("dateLastLoggedIn");
      builder.Property(e => e.Active).HasColumnName("active").HasDefaultValue(true);
      builder.Property(e => e.ActivationHash).HasColumnName("activationHash");
      builder.Property(e => e.ForgotPasswordHash).HasColumnName("forgotPasswordHash");
      builder.Property(e => e.Joyride).HasColumnName("joyride").HasDefaultValue(true);
      builder.Property(e => e.BaAdmin).HasColumnName("baAdmin");
    }
  }
}

