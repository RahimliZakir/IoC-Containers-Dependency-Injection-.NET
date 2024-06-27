using Project.ConsoleApp.AppCode.Common;

namespace Project.ConsoleApp.AppCode.DI.ConstructorBased
{
    // Define a class that depends on the email service using constructor injection
    public class InformationService
    {
        readonly IEmailService emailService;
        // Constructor injection
        public InformationService(IEmailService emailService)
        {
            this.emailService = emailService;
        }

        public void SendNotification(string recipient, string message)
        {
            // Logic to process and send notifications
            emailService.SendEmail(recipient, "Information", message);
        }
    }
}
