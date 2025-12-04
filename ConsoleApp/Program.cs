// See https://aka.ms/new-console-template for more information
using Microsoft.Extensions.Configuration;

var configuration = new ConfigurationBuilder()
    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
    .AddEnvironmentVariables()
    .Build();


Console.WriteLine("ThisIsASetting");

while (true)
{
    Console.WriteLine("Value: '{0}'", configuration["ThisIsASetting"]);
    await Task.Delay(1000);
}
