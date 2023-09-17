using System;
using InvolveMINT.API.Core.PassportDocumentAggregate;
using InvolveMINT.API.SharedKernel;

namespace InvolveMINT.API.Core.EnrollmentAggregate
{
  public class EnrollmentDocumentEntity : EntityBase, IAggregateRoot
  {
    public EnrollmentDocumentEntity(Guid passportDocumentId, Guid projectDocumentId, Guid enrollmentId)
    {
      PassportDocumentId = passportDocumentId;
      ProjectDocumentId = projectDocumentId;
      EnrollmentId = enrollmentId;
    }

    public Guid PassportDocumentId { get; set; }
    public Guid ProjectDocumentId { get; set; }
    public Guid EnrollmentId { get; set; }
  }
}

