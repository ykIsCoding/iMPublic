using System;
using InvolveMINT.API.SharedKernel;

namespace InvolveMINT.API.Core.Aggregates.ChangeMakers
{
  public class PassportDocument : EntityBase<string>, IAggregateRoot
  {
    private PassportDocument()
    {
    }

    public string FilePath { get; set; }
    public string Name { get; set; }
    public DateTime UploadedDate { get; set; }
    public string? ChangeMakerId { get; set; }


  }
}

