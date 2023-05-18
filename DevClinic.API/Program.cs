using DevClinic.Data.Context;
using DevClinic.Data.Repository;
using DevClinic.Domain.Entities;
using DevClinic.Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//String de conex�o
var conectionString = builder.Configuration.GetConnectionString("Database");

builder.Services.AddDbContext<DevClinic_Context>(opttions => opttions.UseSqlServer(conectionString));
//Inje��o de Depend�ncia - Repositorios
builder.Services.AddScoped<IRepositoryBase<Client>, Repositorybase<Client>>();
builder.Services.AddScoped<IClientRepository, ClientRepository>();

//Inje��o de Depend�ncia - Services

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
