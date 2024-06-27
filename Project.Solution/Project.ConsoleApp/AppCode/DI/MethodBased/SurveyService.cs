using Project.ConsoleApp.AppCode.Common;

namespace Project.ConsoleApp.AppCode.DI.MethodBased
{
    // Define a class that depends on the email service
    public class SurveyService
    {
        // 1) For DI

        // Method that requires the email service dependency to be passed
        public void SendNotification(IEmailService emailService, string recipient, string message)
        {
            // Logic to process and send notifications
            emailService.SendEmail(recipient, "Survey", message);


        }

        // 2) For IoC
        private IEmailService emailService;
        public void Initialize(IEmailService emailService)
        {
            this.emailService = emailService;
        }

        public void SendNotificationIoC(string recipient, string message)
        {
            // Logic to process and send notifications
            emailService.SendEmail(recipient, "Survey", message);
        }
    }
}
