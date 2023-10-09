using InvolveMINT.API.SharedKernel;

namespace InvolveMINT.API.Core.ChangeMakerAggregate
{

  public class ChangeMakerEntity : EntityBase<string>, IAggregateRoot
  {
    public ChangeMakerEntity(string firstName, string lastName, string profilePicFilePath, string bio, string phone, ChangeMakerOnboardingState onboardingState)
    {
      FirstName = firstName;
      LastName = lastName;
      ProfilePicFilePath = profilePicFilePath;
      Bio = bio;
      Phone = phone;
      DateCreated = DateTime.Now;
      OnboardingState = onboardingState;
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

