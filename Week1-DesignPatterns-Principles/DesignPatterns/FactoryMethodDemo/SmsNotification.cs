public class SmsNotification : INotification
{
    public void Send(string message)
    {
        Console.WriteLine($"SMS Sent: {message}");
    }
}