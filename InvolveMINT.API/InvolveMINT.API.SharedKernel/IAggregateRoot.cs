namespace InvolveMINT.API.SharedKernel;

/// <summary>
/// Apply this marker interface only to aggregate root entities in the domain model
/// The repository implementation only operates on aggregate roots ensuring domain integrity
/// </summary>
public interface IAggregateRoot { }
