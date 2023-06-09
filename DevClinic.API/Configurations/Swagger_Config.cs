﻿using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.Swagger;
using System.Reflection;

namespace DevClinic.API.Configurations
{
    public static class Swagger_Config
    {
        public static void AddSwaggerConfiguration(this IServiceCollection services)
        {
            services.AddSwaggerGen(s =>
            {
                s.SwaggerDoc("v1",
                    new OpenApiInfo
                    {
                        Title = "Clinic Services",
                        Version = "v1",
                        Description = "API - Aplicação Clinic Service.",
                        Contact = new OpenApiContact
                        {
                            Name = "Júlio C. Mesquita",
                            Email = "juliocesarmcamilo@gmail.com",
                            Url = new Uri("https://portifolio-pessoal-tan.vercel.app/")
                        },
                        License = new OpenApiLicense
                        {
                            Name = "OSD",
                            Url = new Uri("https://opensource.org/osd")
                        },
                        TermsOfService = new Uri("https://github.com/devjuliomesquita")
                    }) ;
                s.AddFluentValidationRulesScoped();
                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                s.IncludeXmlComments(xmlPath);
                xmlPath = Path.Combine(AppContext.BaseDirectory, "DevClinic.Domain.xml");
                s.IncludeXmlComments(xmlPath);
            });
        }

        public static void UseSwaggerConfiguration(this IApplicationBuilder app)
        {
            app.UseSwagger();
            app.UseSwaggerUI(//s =>
            //{
            //    s.RoutePrefix = string.Empty;
            //    s.SwaggerEndpoint("./swagger/v1/swagger.json", "DevClinic.API v1");
            //}
            );
        }
    }
}
