using InvolveMINT.API.SharedKernel;

namespace InvolveMINT.API.Core.Aggregates.Enrollments
{
  public class Enrollment : EntityBase<string>, IAggregateRoot
  {
    public DateTime DateApplied { get; set; }
    public DateTime? DateSubmitted { get; set; }
    public DateTime? DateApproved { get; set; }
    public DateTime? DateDenied { get; set; }
    public DateTime? DateRetired { get; set; }
    public bool AcceptedWaiver { get; set; }
    public string? ChangeMakerId { get; set; }
    public string? ProjectId { get; set; }
    public virtual ICollection<EnrollmentDocument> EnrollmentDocuments { get; set; } = new List<EnrollmentDocument>();
    public virtual ICollection<ProofOfImpact> POIs { get; set; } = new List<ProofOfImpact>();

    private Enrollment()
    {
    }

    public static Enrollment CreateInitialEnrollmentApplication(string changeMakerId, string projectId) {
      Enrollment result = new Enrollment();

      result.Id = Guid.NewGuid().ToString();
      result.ChangeMakerId = changeMakerId;
      result.ProjectId = projectId;
      result.DateApplied =  DateTime.Now;

      return result;
    }
    
  }
}

