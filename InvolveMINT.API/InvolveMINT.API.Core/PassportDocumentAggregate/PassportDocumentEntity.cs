using System;
using InvolveMINT.API.SharedKernel;

namespace InvolveMINT.API.Core.PassportDocumentAggregate
{
  public class PassportDocumentEntity : EntityBase<string>, IAggregateRoot
  {
    public PassportDocumentEntity(string filePath, string name, DateTime uploadedDate)
    {
      FilePath = filePath;
      Name = name;
      UploadedDate = uploadedDate;
    }

    public string FilePath { get; set; }
    public string Name { get; set; }
    public DateTime UploadedDate { get; set; }
    public string? ChangeMakerId { get; set; }


  }
}

