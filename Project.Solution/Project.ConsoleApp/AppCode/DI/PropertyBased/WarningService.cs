using Project.ConsoleApp.AppCode.Common;

namespace Project.ConsoleApp.AppCode.DI.PropertyBased
{
    // Define a class that depends on the email service using property injection
    public class WarningService
    {
        // Property to inject the email service
        public IEmailService EmailService { get; set; }

        public void SendNotification(string recipient, string message)
        {
            // Logic to process and send notifications
            EmailService.SendEmail(recipient, "Warning", message);
        }
    }
}
