using Ardalis.SmartEnum;

namespace InvolveMINT.API.Core.Aggregates.ChangeMakers
{
  public class ChangeMakerOnboardingState : SmartEnum<ChangeMakerOnboardingState>
  {
    public static readonly ChangeMakerOnboardingState PROJECT = new(nameof(PROJECT).ToLower(), 0);
    public static readonly ChangeMakerOnboardingState MARKET = new(nameof(MARKET).ToLower(), 1);
    public static readonly ChangeMakerOnboardingState NONE = new(nameof(NONE).ToLower(), 2);
    public static readonly ChangeMakerOnboardingState DONE = new(nameof(DONE).ToLower(), 3);

    protected ChangeMakerOnboardingState(string name, int value) : base(name, value) { }

  }
}

