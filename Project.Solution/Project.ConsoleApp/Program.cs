using Project.ConsoleApp.AppCode.Common;
using Project.ConsoleApp.AppCode.DI.ConstructorBased;
using Project.ConsoleApp.AppCode.DI.MethodBased;
using Project.ConsoleApp.AppCode.DI.PropertyBased;
using Unity;
using Unity.Injection;

// Constants 
const string RECIPIENT = "Zakir Rahimli";

// Commons
EmailService emailService = new();

// I. Section - Dependency Injection (DI) in C#

// 1) Constructor Injection
Console.WriteLine("Constructor Injection:");

InformationService ınformationService = new(emailService);
ınformationService.SendNotification(RECIPIENT, "We hired you!");

// 2) Property Injection
Console.WriteLine("Property Injection:");

WarningService warningService = new();
warningService.EmailService = emailService;
warningService.SendNotification(RECIPIENT, "2 days left until the project deadline!");

// 3) Method Injection
Console.WriteLine("Method Injection:");

SurveyService surveyService = new();
surveyService.SendNotification(emailService, RECIPIENT, "Are you satisfied with the service?");

// II. Inversion of Control (IoC) Principle (Using 'Unity' Library)
// Setting up Unity IoC container and registering dependencies
UnityContainer unityContainer = new();
unityContainer.RegisterType<IEmailService, EmailService>();

// 1) IoC Container - Constrcutor Injection
Console.WriteLine("IoC Container - Constructor Injection:");

// Resolving and using the NotificationService with injected dependency
InformationService iocInformationService = unityContainer.Resolve<InformationService>();
iocInformationService.SendNotification(RECIPIENT, "Hello, this is a information!");

// 2) IoC Container - Property Injection
Console.WriteLine("IoC Container - Property Injection:");

unityContainer.RegisterType<WarningService>(new InjectionProperty("EmailService"));
WarningService iocWarningService = unityContainer.Resolve<WarningService>();
iocWarningService.SendNotification(RECIPIENT, "Hello, this is a warning!");

// 3) IoC Container - Method Injection
Console.WriteLine("IoC Container - Method Injection:");

unityContainer.RegisterType<SurveyService>(new InjectionMethod("Initialize", new ResolvedParameter<IEmailService>()));
SurveyService iocSurveyService = unityContainer.Resolve<SurveyService>();
iocSurveyService.SendNotificationIoC(RECIPIENT, "Hello, this is an survey!");

Console.ReadKey();