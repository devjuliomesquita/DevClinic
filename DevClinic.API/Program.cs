
using DevClinic.Data.Context;
using DevClinic.Data.Repository;
using DevClinic.Manager.Implementation;
using DevClinic.Manager.Interfaces.Repository;
using DevClinic.Manager.Interfaces.Services;
using DevClinic.Manager.Mappings.Clients;
using DevClinic.Manager.Validator.Clients;
using FluentValidation.AspNetCore;
using Microsoft.EntityFrameworkCore;
using System.Globalization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//Adicionando o fluente validation na controller
builder.Services.AddControllers()
    .AddFluentValidation(v =>
    {
        v.RegisterValidatorsFromAssemblyContaining<CreateClient_Validator>();
        v.RegisterValidatorsFromAssemblyContaining<UpdateClient_Validator>();
        v.ValidatorOptions.LanguageManager.Culture = new CultureInfo("pt-BR");
    });
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//String de conexão
var conectionString = builder.Configuration.GetConnectionString("Database");

builder.Services.AddDbContext<DevClinic_Context>(opttions => opttions.UseSqlServer(conectionString));
//Injeção de Dependência - Repositorios
builder.Services.AddScoped(typeof(IRepositoryBase<>), typeof(Repositorybase<>));
builder.Services.AddScoped<IClientRepository, ClientRepository>();

//Injeção de Dependência - Services
builder.Services.AddScoped(typeof(IServiceBase<>), typeof(ServiceBase<>));
builder.Services.AddScoped<IClientService, ClientService>();

//Injeção de Dependência - AutoMapper
builder.Services.AddAutoMapper(typeof(CreateClient_Mapping), typeof(UpdateClient_Mapping));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
