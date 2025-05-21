public abstract class NotificationDecoration : INotification
{
    protected INotification _notification;

    protected NotificationDecoration(INotification notification)
    {
        _notification = notification;
    }

    public virtual void Send(string message)
    {
        _notification.Send(message);
    }
}
