var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.RpgCharSheet_ApiService>("apiservice")
    .WithHttpHealthCheck("/health");

builder.AddNpmApp("angular", "../RpgCharSheet.Front")
    .WithReference(apiService)
    .WaitFor(apiService)
    .WithHttpEndpoint(env: "PORT", targetPort: 4200)
    .WithExternalHttpEndpoints()
    .WithHttpHealthCheck();

builder.Build().Run();