using System.Reflection;
using InvolveMINT.API.SharedKernel;
using Microsoft.EntityFrameworkCore;
using Ardalis.SmartEnum.EFCore;

using InvolveMINT.API.Core.Aggregates.Addresses;
using InvolveMINT.API.Core.Aggregates.ChangeMakers;
using InvolveMINT.API.Core.Aggregates.Users;
using InvolveMINT.API.Core.Aggregates.ChangeMakers;
using InvolveMINT.API.Core.Aggregates.Enrollments;
using SmartEnum.EFCore;

namespace InvolveMINT.API.Infrastructure.Data;

public class AppDbContext : DbContext
{
  //private readonly IDomainEventDispatcher? _dispatcher;

  public AppDbContext(DbContextOptions<AppDbContext> options)
      : base(options)
  {
    //_dispatcher = dispatcher;
  }

  public DbSet<Address> Addresses => Set<Address>();
  public DbSet<ChangeMaker> ChangeMakers => Set<ChangeMaker>();
  public DbSet<User> Users => Set<User>();
  public DbSet<PassportDocument> PassportDocuments => Set<PassportDocument>();
  public DbSet<Enrollment> Enrollments => Set<Enrollment>();

  protected override void OnModelCreating(ModelBuilder modelBuilder)
  {
    base.OnModelCreating(modelBuilder);
    modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
  }
  protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
  {
    configurationBuilder.ConfigureSmartEnum();
  }

  public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
  {
    //TODO Auto intialize guid id of entities on creation since postgresql wont

    int result = await base.SaveChangesAsync(cancellationToken).ConfigureAwait(false);

    // ignore events if no dispatcher provided
    //if (_dispatcher == null) return result;

    //// dispatch events only if save was successful
    //var entitiesWithEvents = ChangeTracker.Entries<EntityBase<string>,string>>()
    //    .Select(e => e.Entity)
    //    .Where(e => e.DomainEvents.Any())
    //    .ToArray();

    //await _dispatcher.DispatchAndClearEvents(entitiesWithEvents);

    return result;
  }

  public override int SaveChanges()
  {
    return SaveChangesAsync().GetAwaiter().GetResult();
  }
}
