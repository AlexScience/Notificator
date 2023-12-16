using Notificator.Models;

namespace Notificator.Services;

public interface INotificationService
{
    public Task Notify(MediaEvent mediaEvent);
}