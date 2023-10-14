using InvolveMINT.API.SharedKernel;

namespace InvolveMINT.API.Core.Aggregates.ChangeMakers
{

  public class ChangeMaker : EntityBase<string>, IAggregateRoot
  {
    private ChangeMaker()
    {
    }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string? ProfilePicFilePath { get; set; }

    public string? Bio { get; set; }

    public string Phone { get; set; } = null!;

    public ChangeMakerOnboardingState OnboardingState { get; set; } = null!;

    public DateTime DateCreated { get; set; }

    public string? HandleId { get; set; }

    public string? AddressId { get; set; }

  }
}

