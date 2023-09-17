using InvolveMINT.API.UseCases.Contributors;
using InvolveMINT.API.UseCases.Contributors.List;

namespace InvolveMINT.API.Infrastructure.Data.Queries;

public class FakeListContributorsQueryService : IListContributorsQueryService
{
  public Task<IEnumerable<ContributorDTO>> ListAsync()
  {
    var result = new List<ContributorDTO>() { new ContributorDTO(1, "Ardalis"), new ContributorDTO(2, "Snowfrog") };
    return Task.FromResult(result.AsEnumerable());
  }
}
