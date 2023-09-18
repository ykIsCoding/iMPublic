using InvolveMINT.API.SharedKernel;

namespace InvolveMINT.API.Core.ProofOfImpactAggregate
{
  public class QuestionAnswerEntity : EntityBase
  {
    public QuestionAnswerEntity()
    {
    }

    public string Answer { get; set; } = null!;

    public DateTime DateAnswered { get; set; }

    public Guid? QuestionId { get; set; }

    public Guid? PoiId { get; set; }
  }
}

