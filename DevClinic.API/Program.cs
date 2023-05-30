using DevClinic.API.AutoMapper;
using DevClinic.Data.Context;
using DevClinic.Data.Repository;
using DevClinic.Domain.Entities;
using DevClinic.Domain.Interfaces.Repositories;
using DevClinic.Domain.Interfaces.Services;
using DevClinic.Services.Services;
using DevClinic.Services.Validators;
using FluentValidation.AspNetCore;
using Microsoft.EntityFrameworkCore;
using System.Globalization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//Adicionando o fluente validation na controller
builder.Services.AddControllers()
    .AddFluentValidation(v =>
    {
        v.RegisterValidatorsFromAssemblyContaining<ClientValidator>();
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
builder.Services.AddAutoMapper(typeof(DevClinic_Mapper));

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
