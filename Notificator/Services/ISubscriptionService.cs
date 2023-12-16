using Notificator.Models;

namespace Notificator.Services;

public interface ISubscriptionService
{
    public IEnumerable<Subscriber> GetSubscribers(Guid channelId);
}