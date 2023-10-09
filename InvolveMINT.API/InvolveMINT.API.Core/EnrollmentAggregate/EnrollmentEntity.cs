using InvolveMINT.API.SharedKernel;

namespace InvolveMINT.API.Core.EnrollmentAggregate
{
  public class EnrollmentEntity : EntityBase<string>, IAggregateRoot
  {
    public DateTime DateApplied { get; set; }
    public DateTime? DateSubmitted { get; set; }
    public DateTime? DateApproved { get; set; }
    public DateTime? DateDenied { get; set; }
    public DateTime? DateRetired { get; set; }
    public bool AcceptedWaiver { get; set; }
    public string? ChangeMakerId { get; set; }
    public string? ProjectId { get; set; }
    public virtual ICollection<EnrollmentDocumentEntity> EnrollmentDocuments { get; set; } = new List<EnrollmentDocumentEntity>();

    private EnrollmentEntity()
    {
    }

    public static EnrollmentEntity CreateInitialEnrollmentApplication(string changeMakerId, string projectId) {
      EnrollmentEntity result = new EnrollmentEntity();

      result.Id = Guid.NewGuid().ToString();
      result.ChangeMakerId = changeMakerId;
      result.ProjectId = projectId;
      result.DateApplied =  DateTime.Now;

      return result;
    }
    
  }
}

