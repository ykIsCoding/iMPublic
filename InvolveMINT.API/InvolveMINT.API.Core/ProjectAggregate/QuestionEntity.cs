using InvolveMINT.API.SharedKernel;

namespace InvolveMINT.API.Core.ProjectAggregate
{
  public class QuestionEntity : EntityBase<string>
  {
    private QuestionEntity()
    {
    }

    public string Text { get; set; } = null!;

    public string? ProjectId { get; set; }
  }
}

