using InvolveMINT.API.SharedKernel;
namespace InvolveMINT.API.Core.Aggregates.Handles
{
  public class Handle : IAggregateRoot
  {
    private Handle()
    {
    }

    public string Id { get; set; } = null!;
  }
}

