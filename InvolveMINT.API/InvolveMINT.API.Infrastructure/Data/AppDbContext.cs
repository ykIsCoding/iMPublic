using System.Reflection;
using InvolveMINT.API.SharedKernel;
using Microsoft.EntityFrameworkCore;

using InvolveMINT.API.Core.AddressAggregate;
using InvolveMINT.API.Core.ChangeMakerAggregate;
using InvolveMINT.API.Core.UserAggregate;
using InvolveMINT.API.Core.PassportDocumentAggregate;
using InvolveMINT.API.Core.EnrollmentAggregate;

namespace InvolveMINT.API.Infrastructure.Data;

public class AppDbContext : DbContext
{
  private readonly IDomainEventDispatcher? _dispatcher;

  public AppDbContext(DbContextOptions<AppDbContext> options,
    IDomainEventDispatcher? dispatcher)
      : base(options)
  {
    _dispatcher = dispatcher;
  }

  public DbSet<AddressEntity> Addresses => Set<AddressEntity>();
  public DbSet<ChangeMakerEntity> ChangeMakers => Set<ChangeMakerEntity>();
  public DbSet<UserEntity> Users => Set<UserEntity>();
  public DbSet<PassportDocumentEntity> PassportDocuments => Set<PassportDocumentEntity>();
  public DbSet<EnrollmentEntity> Enrollments => Set<EnrollmentEntity>();

  protected override void OnModelCreating(ModelBuilder modelBuilder)
  {
    base.OnModelCreating(modelBuilder);
    modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
  }

  public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
  {
    //TODO Auto intialize guid id of entities on creation since postgresql wont

    int result = await base.SaveChangesAsync(cancellationToken).ConfigureAwait(false);

    // ignore events if no dispatcher provided
    if (_dispatcher == null) return result;

    // dispatch events only if save was successful
    var entitiesWithEvents = ChangeTracker.Entries<EntityBase>()
        .Select(e => e.Entity)
        .Where(e => e.DomainEvents.Any())
        .ToArray();

    await _dispatcher.DispatchAndClearEvents(entitiesWithEvents);

    return result;
  }

  public override int SaveChanges()
  {
    return SaveChangesAsync().GetAwaiter().GetResult();
  }
}
