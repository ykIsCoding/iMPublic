using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using InvolveMINT.API.Core.AddressAggregate;

namespace YourNamespace // Replace with your actual namespace
{
  public class AddressEntityConfiguration : IEntityTypeConfiguration<AddressEntity>
  {
    public void Configure(EntityTypeBuilder<AddressEntity> builder)
    {
      builder.ToTable("Address"); // Set the table name

      builder.HasKey(e => e.Id); // Primary key

      builder.Property(e => e.Id)
          .HasColumnName("id")
          .HasColumnType("text")
          .HasConversion(
              id => id.ToString(),
              str => Guid.Parse(str)
          )
          .IsRequired();

      builder.Property(e => e.Address1).HasColumnName("address1").IsRequired();
      builder.Property(e => e.Address2).HasColumnName("address2");
      builder.Property(e => e.Address3).HasColumnName("address3");
      builder.Property(e => e.City).HasColumnName("city").IsRequired();
      builder.Property(e => e.State).HasColumnName("state").IsRequired();
      builder.Property(e => e.Zip).HasColumnName("zip").IsRequired();
      builder.Property(e => e.Country).HasColumnName("country").HasDefaultValue("United States");
    }
  }
}