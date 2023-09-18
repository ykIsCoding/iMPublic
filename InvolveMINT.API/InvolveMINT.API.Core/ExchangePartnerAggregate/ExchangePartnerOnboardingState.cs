using System;
using Ardalis.SmartEnum;
using InvolveMINT.API.Core.ChangeMakerAggregate;

namespace InvolveMINT.API.Core.ExchangePartnerAggregate
{
  public class ExchangePartnerOnboardingState : SmartEnum<ExchangePartnerOnboardingState>
  {
    public static readonly ExchangePartnerOnboardingState PROFILE = new(nameof(PROFILE).ToLower(), 0);
    public static readonly ExchangePartnerOnboardingState NONE = new(nameof(NONE).ToLower(), 1);

    protected ExchangePartnerOnboardingState(string name, int value) : base(name, value) { }

  }
}

