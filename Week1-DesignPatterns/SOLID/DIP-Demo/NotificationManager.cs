public class NotificationManager
{
    private readonly INotification notification;

    public NotificationManager(INotification notification)
    {
        this.notification = notification;
    }

    public void Notify(string message)
    {
        notification.Send(message);
    }
}