var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.IMS_Web>("ims.web");

builder.Build().Run();
