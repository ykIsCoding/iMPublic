using InvolveMINT.API.SharedKernel;

namespace InvolveMINT.API.Core.EnrollmentAggregate
{
  public class EnrollmentDocumentEntity : EntityBase<string>
  {
    private EnrollmentDocumentEntity()
    {

    }

    public string PassportDocumentId { get; set; }
    public string ProjectDocumentId { get; set; }
    public string EnrollmentId { get; set; }
  }
}

