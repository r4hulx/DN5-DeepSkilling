public class SmsService : INotification
{
    public void Send(string message)
    {
        Console.WriteLine($"SMS Sent: {message}");
    }
}