public class SmsNotification : NotificationDecoration
{
    public SmsNotification(INotification notification) : base(notification)
    {
    }

    public override void Send(string message)
    {
        base.Send(message);
        Console.WriteLine($"from SmsNotification: {message}");
    }
}