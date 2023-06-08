
using DevClinic.API.Configurations;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddLogSerilogConfiguration();


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


app.UseExceptionHandler("/error");
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.UseSwaggerConfiguration();
}

app.UseDatabaseConfiguration();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
