using InvolveMINT.API.SharedKernel;

namespace InvolveMINT.API.Core.ProofOfImpactAggregate
{
  public class ProofOfImpactEntity : EntityBase<string>, IAggregateRoot
  {
    public ProofOfImpactEntity()
    {
    }

    public DateTime DateCreated { get; set; }

    public DateTime? DateStarted { get; set; }

    public DateTime? DateStopped { get; set; }

    public DateTime? DateSubmitted { get; set; }

    public DateTime? DateApproved { get; set; }

    public DateTime? DateDenied { get; set; }

    public string[]? ImagesFilePaths { get; set; }

    public string[]? PausedTimes { get; set; }

    public string[]? ResumedTimes { get; set; }

    public double? Longitude { get; set; }

    public double? Latitude { get; set; }

    public string? EnrollmentId { get; set; }
  }
}

