using InvolveMINT.API.SharedKernel;

namespace InvolveMINT.API.Core.Aggregates.Enrollments
{
  public class QuestionAnswer : EntityBase<string>
  {
    private QuestionAnswer()
    {
    }

    public string Answer { get; set; } = null!;

    public DateTime DateAnswered { get; set; }

    public string? QuestionId { get; set; }

    public string? PoiId { get; set; }
  }
}

