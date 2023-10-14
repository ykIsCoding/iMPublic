using InvolveMINT.API.SharedKernel;

namespace InvolveMINT.API.Core.Aggregates.Projects
{
  public class Question : EntityBase<string>
  {
    private Question()
    {
    }

    public string Text { get; set; } = null!;

    public string? ProjectId { get; set; }
  }
}

