using ApniDukaan.Infrastructure;
using ApniDukaan.Core;
using ApniDukaan.API.Middleware;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Adding infrastructure services to the dependency injection container using the extension method defined in the Infrastructure project.
builder.Services.AddInfrastructureServices();
builder.Services.AddCoreServices();

// Add Controllers to the Service collections
builder.Services.AddControllers().AddJsonOptions(
    options => options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter()));

// Build the Web application
var app = builder.Build();

// Adding Exception Handling Middleware to the HTTP request pipeline using the extension method defined in the API project.
app.UseExceptionHandlingMiddleware();

// Routing
app.UseRouting();

// Authentication and Authorization
app.UseAuthentication();
app.UseAuthorization();

// Controller routes
app.MapControllers();

//app.MapGet("/", () => "Hello World!");

app.Run();
