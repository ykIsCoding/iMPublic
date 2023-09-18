using InvolveMINT.API.Core.ProjectDocumentAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InvolveMINT.API.Infrastructure.Data.Config
{
  public class ProjectDocumentEntityConfiguration : IEntityTypeConfiguration<ProjectDocumentEntity>
  {
    public void Configure(EntityTypeBuilder<ProjectDocumentEntity> builder)
    {
      builder.HasKey(e => e.Id);

      builder.ToTable("ProjectDocument");

      builder.Property(e => e.Id)
        .HasColumnName("id")
        .HasColumnType("text")
        .HasConversion(
            id => id.ToString(),
            str => Guid.Parse(str)
        )
        .IsRequired();

      builder.Property(e => e.Description)
          .HasColumnType("character varying")
          .HasColumnName("description");

      builder.Property(e => e.InfoUrl)
          .HasColumnType("character varying")
          .HasColumnName("infoUrl");

      builder.Property(e => e.ProjectId)
        .HasColumnName("projectId")
        .HasColumnType("text")
        .HasConversion(
            id => id.ToString(),
            str => str == null ? null : Guid.Parse(str)
        );

      builder.Property(e => e.Title)
        .HasColumnType("character varying")
        .HasColumnName("title");
    }
  }
}

