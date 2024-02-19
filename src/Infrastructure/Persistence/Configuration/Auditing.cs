using Finbuckle.MultiTenant.EntityFrameworkCore;
using BettingBook.Infrastructure.Auditing;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BettingBook.Infrastructure.Persistence.Configuration;

public class AuditTrailConfig : IEntityTypeConfiguration<Trail>
{
    public void Configure(EntityTypeBuilder<Trail> builder) =>
        builder
            .ToTable("AuditTrails", SchemaNames.Auditing)
            .IsMultiTenant();
}