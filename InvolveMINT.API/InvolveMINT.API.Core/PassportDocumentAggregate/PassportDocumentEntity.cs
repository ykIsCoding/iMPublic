using System;
using InvolveMINT.API.SharedKernel;

namespace InvolveMINT.API.Core.PassportDocumentAggregate
{
  public class PassportDocumentEntity : EntityBase<string>, IAggregateRoot
  {
    private PassportDocumentEntity()
    {
    }

    public string FilePath { get; set; }
    public string Name { get; set; }
    public DateTime UploadedDate { get; set; }
    public string? ChangeMakerId { get; set; }


  }
}

