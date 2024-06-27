namespace Project.ConsoleApp.AppCode.Common
{
    // Define an interface for the email service
    public interface IEmailService
    {
        void SendEmail(string recipient, string subject, string body);
    }
}
