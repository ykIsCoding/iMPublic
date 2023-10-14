using InvolveMINT.API.Core.Aggregates.ChangeMakers;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InvolveMINT.API.Infrastructure.Data.Config
{
  public class PassportDocumentConfiguration : IEntityTypeConfiguration<PassportDocument>
  {
    public void Configure(EntityTypeBuilder<PassportDocument> builder)
    {
      builder.ToTable("PassportDocuments");

      builder.Property(e => e.Id)
          .HasColumnName("id")
          .HasColumnType("text")
      .IsRequired();

      builder.Property(e => e.ChangeMakerId)
        .HasColumnName("changeMakerId")
        .HasColumnType("text");

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

