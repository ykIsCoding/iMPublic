using Ardalis.SmartEnum;

namespace InvolveMINT.API.Core.ChangeMakerAggregate
{
  public class ChangeMakerOnboardingState : SmartEnum<ChangeMakerOnboardingState>
  {
    ChangeMakerOnboardingState PROJECT = new(nameof(PROJECT).ToLower(), 0);
    ChangeMakerOnboardingState MARKET = new(nameof(MARKET).ToLower(), 0);
    ChangeMakerOnboardingState NONE = new(nameof(NONE).ToLower(), 0);
    ChangeMakerOnboardingState DONE = new(nameof(DONE).ToLower(), 0);

    protected ChangeMakerOnboardingState(string name, int value) : base(name, value) { }

  }
}

