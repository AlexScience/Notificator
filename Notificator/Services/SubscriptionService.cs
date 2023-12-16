using Notificator.Models;

namespace Notificator.Services;

public class SubscriptionService : ISubscriptionService
{
    public IEnumerable<Subscriber> GetSubscribers(Guid channelId)
    {
        throw new NotImplementedException();
    }
}