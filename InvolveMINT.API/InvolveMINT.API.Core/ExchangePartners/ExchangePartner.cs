using InvolveMINT.API.SharedKernel;

namespace InvolveMINT.API.Core.Aggregates.ExchangePartners
{
  public class ExchangePartner : EntityBase<string>, IAggregateRoot
  {
    private ExchangePartner()
    {
    }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public string? LogoFilePath { get; set; }

    public string Website { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Ein { get; set; } = null!;

    public string[] ImagesFilePaths { get; set; } = null!;

    public string ListStoreFront { get; set; } = null!;

    public DateTime BudgetEndDate { get; set; }

    public int Budget { get; set; }

    public double? Latitude { get; set; }

    public double? Longitude { get; set; }

    public DateTime DateCreated { get; set; }

    public ExchangePartnerOnboardingState OnboardingState { get; set; } = null!;

    public string? HandleId { get; set; }

    public string? AddressId { get; set; }

    public ExchangeAdmin? ExchangeAdmin { get; set; }
  }
}

