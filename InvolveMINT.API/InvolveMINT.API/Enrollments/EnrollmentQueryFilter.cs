using System;
namespace InvolveMINT.API.Enrollments
{
  public readonly record struct EnrollmentQueryFilter(Guid? ChangeMakerId=null, Guid? servePartnerId=null);
}

