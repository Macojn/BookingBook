using BettingBook.Shared.Events;

namespace BettingBook.Domain.Common.Contracts;

public abstract class DomainEvent : IEvent
{
    public DateTime TriggeredOn { get; protected set; } = DateTime.UtcNow;
}