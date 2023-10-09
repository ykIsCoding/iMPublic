using InvolveMINT.API.Core.ProofOfImpactAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InvolveMINT.API.Infrastructure.Data.Config.ProofOfImpactConfigurations
{
  public class QuestionAnswerEntityConfiguration : IEntityTypeConfiguration<QuestionAnswerEntity>
  {
    public void Configure(EntityTypeBuilder<QuestionAnswerEntity> builder)
    {
      builder.HasKey(e => e.Id);

      builder.ToTable("QuestionAnswer");

      builder.Property(e => e.Id)
        .HasColumnName("id")
        .HasColumnType("text")
        .IsRequired();

      builder.Property(e => e.Answer)
          .HasColumnType("character varying")
          .HasColumnName("answer");

      builder.Property(e => e.DateAnswered)
          .HasDefaultValueSql("'2023-09-12 22:45:56.956236'::timestamp without time zone")
          .HasColumnType("timestamp without time zone")
          .HasColumnName("dateAnswered");

      builder.Property(e => e.PoiId)
        .HasColumnName("poiId")
        .HasColumnType("text");

      builder.Property(e => e.QuestionId)
        .HasColumnName("questionId")
        .HasColumnType("text");
    }
  }
}

