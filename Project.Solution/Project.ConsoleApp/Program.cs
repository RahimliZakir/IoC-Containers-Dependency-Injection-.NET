using Project.ConsoleApp.AppCode.Common;
using Project.ConsoleApp.AppCode.DI.ConstructorBased;
using Project.ConsoleApp.AppCode.DI.MethodBased;
using Project.ConsoleApp.AppCode.DI.PropertyBased;

// Constants 
const string RECIPIENT = "Zakir Rahimli";

// Commons
EmailService emailService = new();

// 1) Constructor Injection
InformationService ınformationService = new(emailService);
ınformationService.SendNotification(RECIPIENT, "We hired you!");

// 2) Property Injection
WarningService warningService = new();
warningService.EmailService = emailService;
warningService.SendNotification(RECIPIENT, "2 days left until the project deadline!");

// 3) Method Injection
SurveyService surveyService = new();
surveyService.SendNotification(emailService, RECIPIENT, "Are you satisfied with the service?");

Console.ReadKey();