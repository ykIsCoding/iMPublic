using InvolveMINT.API.SharedKernel;

namespace InvolveMINT.API.Core.ProjectAggregate
{
  public class ProjectDocumentEntity : EntityBase<string>
  {
    private ProjectDocumentEntity()
    {
    }

    public string Title { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string InfoUrl { get; set; } = null!;

    public string? ProjectId { get; set; }
  }
}

