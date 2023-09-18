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

      builder.Property(e => e.ChangeMakerId)
        .HasColumnName("changeMakerId")
        .HasColumnType("text")
        .HasConversion(
            id => id.ToString(),
            str => str == null ? null : Guid.Parse(str)
        );

      builder.Property(e => e.FilePath)
          .HasColumnType("character varying")
          .HasColumnName("filePath");

      builder.Property(e => e.Name)
          .HasColumnType("character varying")
          .HasColumnName("name");

      builder.Property(e => e.UploadedDate)
          .HasColumnType("timestamp without time zone")
          .HasColumnName("uploadedDate");
    }
  }
}

