using InvolveMINT.API.SharedKernel;

namespace InvolveMINT.API.Core.Aggregates.Enrollments
{
  public class EnrollmentDocument : EntityBase<string>
  {
    private EnrollmentDocument()
    {

    }

    public string PassportDocumentId { get; set; }
    public string ProjectDocumentId { get; set; }
    public string EnrollmentId { get; set; }
  }
}

