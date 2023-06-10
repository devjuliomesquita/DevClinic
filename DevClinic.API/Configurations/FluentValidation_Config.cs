using DevClinic.Manager.Validator.Address;
using DevClinic.Manager.Validator.Clients;
using DevClinic.Manager.Validator.Contacts;
using DevClinic.Manager.Validator.Doctors;
using DevClinic.Manager.Validator.Specialities;
using FluentValidation.AspNetCore;
using Newtonsoft.Json;
using System.Globalization;


namespace DevClinic.API.Configurations
{
    public static class FluentValidation_Config
    {
        public static void AddFluentValidationConfiguration(this IServiceCollection services)
        {
            services.AddControllers()
                .AddNewtonsoftJson(s =>s.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore)
                .AddFluentValidation(f =>
                {
                    f.RegisterValidatorsFromAssemblyContaining<CreateClient_Validator>();
                    f.RegisterValidatorsFromAssemblyContaining<UpdateClient_Validator>();
                    f.RegisterValidatorsFromAssemblyContaining<CreateAddress_Validator>();
                    f.RegisterValidatorsFromAssemblyContaining<CreatePhone_Validator>();
                    f.RegisterValidatorsFromAssemblyContaining<CreateEmail_Validator>();
                    f.RegisterValidatorsFromAssemblyContaining<CreateDoctor_Validator>();
                    f.RegisterValidatorsFromAssemblyContaining<UpdateDoctor_Validator>();
                    f.RegisterValidatorsFromAssemblyContaining<CreateSpeciality_Validator>();
                    f.RegisterValidatorsFromAssemblyContaining<UpdateSpeciality_Validator>();
                    f.RegisterValidatorsFromAssemblyContaining<ReferenceSpeciality_Validator>();
                    f.ValidatorOptions.LanguageManager.Culture = new CultureInfo("pt-BR");
                }
                );
        }
    }
}
