using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Ordering.Application;
using Ordering.Infrastructure;
using Ordering.Presentation;
using Serilog;

var builder = WebApplication.CreateBuilder(args);
var presentationAssembly = typeof(Ordering.Presentation.AssemblyReference).Assembly;

builder.Services.AddControllers()
           .AddApplicationPart(presentationAssembly);

builder.Services
    .AddApplication()
    .AddInfrastructure()
    .AddPresentation();

builder.Services.AddDbContext<ApplicationDbContext>(context =>
        context.UseNpgsql(builder.Configuration.GetConnectionString("OrderingConnectionString")));

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Host.UseSerilog((context, configuration) =>
    configuration.ReadFrom.Configuration(context.Configuration));

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseSerilogRequestLogging();

app.Run();
