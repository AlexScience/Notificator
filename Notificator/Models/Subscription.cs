namespace Notificator.Models;

public record Subscription
{
    public Subscription(Guid channelId, Guid subscriberId)
    {
        Id = Guid.NewGuid();
        ChannelId = channelId;
        SubscriberId = subscriberId;
        IsActive = true;
    }

    public Subscription()
    {
        
    }
    public Guid Id { get; }
    public Guid ChannelId { get; }
    public Guid SubscriberId { get; }

    public bool IsActive { get; init; }
}