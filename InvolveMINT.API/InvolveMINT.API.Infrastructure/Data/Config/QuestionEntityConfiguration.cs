using InvolveMINT.API.Core.Aggregates.Projects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InvolveMINT.API.Infrastructure.Data.Config
{
  public class QuestionConfiguration : IEntityTypeConfiguration<Question>
  {
    public void Configure(EntityTypeBuilder<Question> builder)
    {
      builder.HasKey(e => e.Id);
      builder.ToTable("Question");

      builder.Property(e => e.Id)
        .HasColumnName("id")
        .HasColumnType("text")
        .IsRequired();

      builder.Property(e => e.ProjectId)
        .HasColumnName("projectId")
        .HasColumnType("text")
        .HasColumnType("text");

      builder.Property(e => e.Text)
        .HasColumnType("character varying")
        .HasColumnName("text");
    }
  }
}

