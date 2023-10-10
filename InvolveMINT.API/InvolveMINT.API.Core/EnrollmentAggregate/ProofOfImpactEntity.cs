using InvolveMINT.API.SharedKernel;

namespace InvolveMINT.API.Core.EnrollmentAggregate
{
  public class ProofOfImpactEntity : EntityBase<string>
  {
    private ProofOfImpactEntity()
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

    public virtual ICollection<TaskEntity> Tasks { get; set; } = new List<TaskEntity>();
    public virtual ICollection<QuestionAnswerEntity> QuestionAnswers { get; set; } = new List<QuestionAnswerEntity>();

  }
}

