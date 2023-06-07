
using DevClinic.API.Configurations;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

//LOG E SERILOG
string environmentDev = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
var config = new ConfigurationBuilder()
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json")
    .AddJsonFile($"appsettings.{environmentDev}.json")
    .Build();

var logger = new LoggerConfiguration()
    .ReadFrom.Configuration(config)
    .CreateLogger();
builder.Services.AddSerilog(logger);

try
{
    Log.Information("API iniciada.");
}
catch (Exception ex)
{

    Log.Fatal(ex, "Erro Demoníaco.");
    throw;
}
finally
{
    Log.CloseAndFlush();
}

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddFluentValidationConfiguration();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddDependencyInjectionConfiguration();
builder.Services.AddAutoMapperConfiguration();
builder.Services.AddSwaggerConfiguration();
builder.Services.AddDatabaseConfigutation(builder.Configuration);


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseDatabaseConfiguration();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
