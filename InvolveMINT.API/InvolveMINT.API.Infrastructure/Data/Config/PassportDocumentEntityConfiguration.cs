using InvolveMINT.API.Core.PassportDocumentAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InvolveMINT.API.Infrastructure.Data.Config
{
  public class PassportDocumentEntityConfiguration : IEntityTypeConfiguration<PassportDocumentEntity>
  {
    public void Configure(EntityTypeBuilder<PassportDocumentEntity> builder)
    {
      builder.ToTable("PassportDocuments");

      builder.Property(e => e.Id)
          .HasColumnName("id")
          .HasColumnType("text")
          .HasConversion(
              id => id.ToString(),
              str => Guid.Parse(str)
          )
          .IsRequired();

      builder.Property(e => e.FilePath).HasColumnName("filePath").IsRequired();
      builder.Property(e => e.Name).HasColumnName("name").IsRequired();
      builder.Property(e => e.UploadedDate).HasColumnName("uploadedDate");
    }
  }
}

