namespace Project.ConsoleApp.AppCode.Common
{
    // Implement the email service
    public class EmailService : IEmailService
    {
        public void SendEmail(string recipient, string subject, string body)
        {
            // Code to send email
            Console.WriteLine($"Email recipient: {recipient}, subject: {subject}, body: {body}");
        }
    }
}
