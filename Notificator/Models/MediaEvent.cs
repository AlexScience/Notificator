namespace Notificator.Models;

public record MediaEvent
{
    public MediaEvent(Guid channelId, MediaObjectInfo mediaObjectInfo)
    {
        Id = Guid.NewGuid();
        ChannelId = channelId;
        MediaObjectInfo = mediaObjectInfo;
    }

    public Guid Id { get; }
    public Guid ChannelId { get; }
    
    public MediaObjectInfo MediaObjectInfo { get; }
}