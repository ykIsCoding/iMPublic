using InvolveMINT.API.Core.Aggregates.Projects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InvolveMINT.API.Infrastructure.Data.Config
{
  public class ProjectDocumentConfiguration : IEntityTypeConfiguration<ProjectDocument>
  {
    public void Configure(EntityTypeBuilder<ProjectDocument> builder)
    {
      builder.HasKey(e => e.Id);

      builder.ToTable("ProjectDocument");

      builder.Property(e => e.Id)
        .HasColumnName("id")
        .HasColumnType("text")
        .IsRequired();

      builder.Property(e => e.Description)
          .HasColumnType("character varying")
          .HasColumnName("description");

      builder.Property(e => e.InfoUrl)
          .HasColumnType("character varying")
          .HasColumnName("infoUrl");

      builder.Property(e => e.ProjectId)
        .HasColumnName("projectId")
        .HasColumnType("text");

      builder.Property(e => e.Title)
        .HasColumnType("character varying")
        .HasColumnName("title");
    }
  }
}

