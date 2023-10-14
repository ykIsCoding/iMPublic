using InvolveMINT.API.Core.Aggregates.Enrollments;

namespace InvolveMINT.API.Core.Services.Interfaces;

public interface IEnrollInProjectService
{
    Task<Enrollment> EnrollInProject(string changeMakerId, string projectId);
}
