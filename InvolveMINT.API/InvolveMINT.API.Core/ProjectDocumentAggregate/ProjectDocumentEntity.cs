using InvolveMINT.API.SharedKernel;

namespace InvolveMINT.API.Core.ProjectDocumentAggregate
{
  public class ProjectDocumentEntity : EntityBase<string>, IAggregateRoot
  {
    public ProjectDocumentEntity()
    {
    }

    public string Title { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string InfoUrl { get; set; } = null!;

    public string? ProjectId { get; set; }
  }
}

