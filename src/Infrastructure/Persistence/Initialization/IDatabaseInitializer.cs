using BettingBook.Infrastructure.Multitenancy;

namespace BettingBook.Infrastructure.Persistence.Initialization;

internal interface IDatabaseInitializer
{
    Task InitializeDatabasesAsync(CancellationToken cancellationToken);
    Task InitializeApplicationDbForTenantAsync(FSHTenantInfo tenant, CancellationToken cancellationToken);
}