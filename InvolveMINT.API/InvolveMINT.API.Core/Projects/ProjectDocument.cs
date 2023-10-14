using InvolveMINT.API.SharedKernel;

namespace InvolveMINT.API.Core.Aggregates.Projects
{
  public class ProjectDocument : EntityBase<string>
  {
    private ProjectDocument()
    {
    }

    public string Title { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string InfoUrl { get; set; } = null!;

    public string? ProjectId { get; set; }
  }
}

