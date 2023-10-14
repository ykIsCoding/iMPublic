using InvolveMINT.API.SharedKernel;

namespace InvolveMINT.API.Core.Aggregates.ServePartners
{
  public class ServePartner : EntityBase<string>, IAggregateRoot
  {
    private ServePartner()
    {
    }

    public string Email { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public string Website { get; set; } = null!;

    public string? LogoFilePath { get; set; }

    public string[] ImagesFilePaths { get; set; } = null!;

    public string? Description { get; set; }

    public double? Latitude { get; set; }

    public double? Longitude { get; set; }

    public DateTime DateCreated { get; set; }

    public string? HandleId { get; set; }

    public string? AddressId { get; set; }
  }
}

