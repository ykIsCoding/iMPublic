namespace InvolveMINT.API.Enrollments
{
  public readonly record struct EnrollmentQueryFilter(Guid? ChangeMakerId=null, Guid? ServePartnerId=null);
}

