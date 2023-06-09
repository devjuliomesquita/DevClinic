﻿using DevClinic.Data.Repository;
using DevClinic.Manager.Implementation;
using DevClinic.Manager.Interfaces.Repository;
using DevClinic.Manager.Interfaces.Services;

namespace DevClinic.API.Configurations
{
    public static class DependencyInjection_Config
    {
        public static void AddDependencyInjectionConfiguration(this IServiceCollection services)
        {
            services.AddScoped(typeof(IRepositoryBase<>), typeof(Repositorybase<>));
            services.AddScoped<IClientRepository, ClientRepository>();
            services.AddScoped<IDoctorRepository, DoctorRepository>();
            services.AddScoped<ISpecialityRepository, SpecialityRepository>();
            services.AddTransient<IDoctorSpecialityRepository, DoctorSpecialityRepository>();

            services.AddScoped(typeof(IServiceBase<>), typeof(ServiceBase<>));
            services.AddScoped<IClientService, ClientService>();
            services.AddScoped<IDoctorService, DoctorService>();
            services.AddScoped<ISpecialityService, SpecialityService>();
            services.AddTransient<IDoctorSpecialityService, DoctorSpecialityService>();
        }
    }
}
