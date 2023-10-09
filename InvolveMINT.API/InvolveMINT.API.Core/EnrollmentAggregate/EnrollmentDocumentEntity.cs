using System;
using InvolveMINT.API.Core.PassportDocumentAggregate;
using InvolveMINT.API.SharedKernel;

namespace InvolveMINT.API.Core.EnrollmentAggregate
{
  public class EnrollmentDocumentEntity : EntityBase<string>, IAggregateRoot
  {
    private EnrollmentDocumentEntity(string passportDocumentId, string projectDocumentId, string enrollmentId)
    {
      PassportDocumentId = passportDocumentId;
      ProjectDocumentId = projectDocumentId;
      EnrollmentId = enrollmentId;
    }

    public string PassportDocumentId { get; set; }
    public string ProjectDocumentId { get; set; }
    public string EnrollmentId { get; set; }
  }
}

