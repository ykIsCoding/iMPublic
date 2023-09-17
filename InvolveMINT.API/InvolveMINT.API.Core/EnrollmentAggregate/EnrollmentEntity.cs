using InvolveMINT.API.SharedKernel;

namespace InvolveMINT.API.Core.EnrollmentAggregate
{
  public class EnrollmentEntity : EntityBase, IAggregateRoot
  {
    public EnrollmentEntity(DateTime dateApplied, DateTime? dateSubmitted, DateTime? dateApproved, DateTime? dateDenied, DateTime? dateRetired, bool acceptedWaiver)
    {
      DateApplied = dateApplied;
      DateSubmitted = dateSubmitted;
      DateApproved = dateApproved;
      DateDenied = dateDenied;
      DateRetired = dateRetired;
      AcceptedWaiver = acceptedWaiver;
    }

    public DateTime DateApplied { get; set; }
    public DateTime? DateSubmitted { get; set; }
    public DateTime? DateApproved { get; set; }
    public DateTime? DateDenied { get; set; }
    public DateTime? DateRetired { get; set; }
    public bool AcceptedWaiver { get; set; }
    public Guid ChangeMakerId { get; set; }
    public Guid ProjectId { get; set; }

    public List<EnrollmentDocumentEntity> EnrollmentDocuments { get; set; } = new List<EnrollmentDocumentEntity>();
  }
}

