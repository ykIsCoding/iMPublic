using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using InvolveMINT.API.Core.AddressAggregate;

namespace InvolveMINT.API.Infrastructure.Data.Config
{
  public class AddressEntityConfiguration : IEntityTypeConfiguration<AddressEntity>
  {
    public void Configure(EntityTypeBuilder<AddressEntity> builder)
    {

      builder.ToTable("Address");

      builder.HasKey(e => e.Id);

      builder.Property(e => e.Id)
        .HasColumnName("id")
          .HasColumnType("text")
          .IsRequired();

      builder.Property(e => e.Address1)
          .HasColumnType("character varying")
          .HasColumnName("address1");

      builder.Property(e => e.Address2)
          .HasColumnType("character varying")
          .HasColumnName("address2");

      builder.Property(e => e.Address3)
          .HasColumnType("character varying")
          .HasColumnName("address3");

      builder.Property(e => e.City)
          .HasColumnType("character varying")
          .HasColumnName("city");

      builder.Property(e => e.Country)
          .HasDefaultValueSql("'Unites States'::character varying")
          .HasColumnType("character varying")
          .HasColumnName("country");

      builder.Property(e => e.State)
          .HasColumnType("character varying")
          .HasColumnName("state");

      builder.Property(e => e.Zip)
          .HasColumnType("character varying")
          .HasColumnName("zip");
    }
  }
}