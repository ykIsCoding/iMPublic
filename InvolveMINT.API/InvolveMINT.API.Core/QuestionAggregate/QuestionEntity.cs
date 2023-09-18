using InvolveMINT.API.SharedKernel;

namespace InvolveMINT.API.Core.QuestionAggregate
{
  public class QuestionEntity : EntityBase, IAggregateRoot
  {
    public QuestionEntity()
    {
    }

    public string Text { get; set; } = null!;

    public Guid? ProjectId { get; set; }
  }
}

