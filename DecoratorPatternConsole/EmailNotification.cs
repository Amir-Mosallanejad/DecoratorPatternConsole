public class EmailNotification : INotification
{
    public void Send(string message)
    {
        Console.WriteLine($"from EmailNotification: {message}");
    }
}
