// See https://aka.ms/new-console-template for more information
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);

// Register services
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddControllers();

var app = builder.Build();


app.UseRouting();

app.UseAuthorization();

app.MapControllers();

// Example: Test minimal endpoint
app.MapGet("/", () => "Hello from Console + Web API!");

app.Run();

