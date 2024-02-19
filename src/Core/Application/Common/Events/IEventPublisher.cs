using BettingBook.Shared.Events;

namespace BettingBook.Application.Common.Events;

public interface IEventPublisher : ITransientService
{
    Task PublishAsync(IEvent @event);
}