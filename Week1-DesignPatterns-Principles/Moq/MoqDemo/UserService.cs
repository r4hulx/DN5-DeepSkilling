namespace MoqDemo;

public class UserService
{
    private readonly IEmailService emailService;

    public UserService(IEmailService emailService)
    {
        this.emailService = emailService;
    }

    public bool Register(string email)
    {
        return emailService.SendEmail(email);
    }
}