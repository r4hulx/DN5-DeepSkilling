namespace MoqDemo;

public class OrderService
{
    private readonly IEmailService emailService;

    public OrderService(IEmailService emailService)
    {
        this.emailService = emailService;
    }

    public bool Register(string email)
    {
        try
        {
            return emailService.SendEmail(email);
        }
        catch
        {
            return false;
        }
    }
}