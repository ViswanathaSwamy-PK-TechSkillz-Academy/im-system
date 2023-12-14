var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.IM_Systems_Web>("im.systems.web");

builder.Build().Run();
