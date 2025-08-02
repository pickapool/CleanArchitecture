using Application;
using Infrastructure;
using Presentation;
using Serilog;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();
builder.Services.AddOpenApi();

builder.Services
    .AddApplicationLayer()
    .AddinfrastructureLayer()
    .AddPresentationLayer();

builder.Host.UseSerilog((context, configuration) =>
    configuration.ReadFrom.Configuration(context.Configuration));

var app = builder.Build();

8
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseSerilogRequestLogging();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
