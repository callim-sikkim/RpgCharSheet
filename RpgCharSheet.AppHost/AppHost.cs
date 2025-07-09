var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.RpgCharSheet_ApiService>("apiservice")
    .WithHttpHealthCheck("/health");

builder
    .AddNpmApp("RpgCharSheetFrontend", "../RpgCharSheet.Frontend")
    .WithExternalHttpEndpoints()
    // .WithHttpHealthCheck("/health") //TODO add health check
    .WithEndpoint(targetPort: 4200, port: 4200, name: "http", env: "PORT", isProxied: false)
    .WaitFor(apiService);

builder.Build().Run();