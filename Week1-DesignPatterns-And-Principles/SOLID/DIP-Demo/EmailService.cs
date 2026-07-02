public class EmailService : INotification
{
    public void Send(string message)
    {
        Console.WriteLine($"Email Sent: {message}");
    }
}