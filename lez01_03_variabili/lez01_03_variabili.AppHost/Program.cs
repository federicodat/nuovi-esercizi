var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.lez01_03_variabili_ApiService>("apiservice");

builder.AddProject<Projects.lez01_03_variabili_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(apiService);

builder.Build().Run();
