using Microsoft.Extensions.Hosting;
using SimpleConsoleApp;

//var settings = Configuration.BuildAppSettings();

var builder = Host.CreateApplicationBuilder(args);
var config = builder.Configuration;
Console.WriteLine($"Current Environment: {builder.Environment.EnvironmentName}");
Console.WriteLine(config["MySetting"]);
//Console.WriteLine(settings.AppName);
//Console.WriteLine(settings.ProviderName);
//Console.WriteLine(settings?.ConnectionStrings?.DbBox);
Console.ReadKey();

