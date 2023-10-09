using InvolveMINT.API.SharedKernel;

namespace InvolveMINT.API.Core.QuestionAggregate
{
  public class QuestionEntity : EntityBase<string>, IAggregateRoot
  {
    public QuestionEntity()
    {
    }

    public string Text { get; set; } = null!;

    public string? ProjectId { get; set; }
  }
}

