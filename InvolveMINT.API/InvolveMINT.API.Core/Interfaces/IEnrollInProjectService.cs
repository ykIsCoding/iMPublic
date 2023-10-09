using InvolveMINT.API.Core.ChangeMakerAggregate;
using InvolveMINT.API.Core.EnrollmentAggregate;
using InvolveMINT.API.Core.ProjectAggregate;

namespace InvolveMINT.API.Core;

public interface IEnrollInProjectService
{
    Task<EnrollmentEntity> EnrollInProject(string changeMakerId, string projectId);
}
