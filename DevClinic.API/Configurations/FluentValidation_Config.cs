using DevClinic.Manager.Validator.Clients;
using FluentValidation.AspNetCore;
using System.Globalization;
using System.Xml.Serialization;

namespace DevClinic.API.Configurations
{
    public static class FluentValidation_Config
    {
        public static void AddFluentValidationConfiguration(this IServiceCollection services)
        {
            services.AddControllers()
                .AddFluentValidation(f =>
                {
                    f.RegisterValidatorsFromAssemblyContaining<CreateClient_Validator>();
                    f.RegisterValidatorsFromAssemblyContaining<UpdateClient_Validator>();
                    f.ValidatorOptions.LanguageManager.Culture = new CultureInfo("pt-BR");
                }
                );
        }
    }
}
