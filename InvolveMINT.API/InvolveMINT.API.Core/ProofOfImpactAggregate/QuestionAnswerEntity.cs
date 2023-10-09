using InvolveMINT.API.SharedKernel;

namespace InvolveMINT.API.Core.ProofOfImpactAggregate
{
  public class QuestionAnswerEntity : EntityBase<string>
  {
    public QuestionAnswerEntity()
    {
    }

    public string Answer { get; set; } = null!;

    public DateTime DateAnswered { get; set; }

    public string? QuestionId { get; set; }

    public string? PoiId { get; set; }
  }
}

