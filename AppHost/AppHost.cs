using Aspire.Hosting;

var builder = DistributedApplication.CreateBuilder(args);

var app = builder.AddProject<Projects.ConsoleApp>("app-none");

var app2 = builder.AddProject<Projects.ConsoleApp>("app-empty")
    .WithEnvironment("ThisIsASetting", string.Empty);

var app3 = builder.AddProject<Projects.ConsoleApp>("app-string")
    .WithEnvironment("ThisIsASetting", "Set in AppHost");

var app4 = builder.AddProject<Projects.ConsoleApp>("app-space")
    .WithEnvironment("ThisIsASetting", " ");

builder.Build().Run();
