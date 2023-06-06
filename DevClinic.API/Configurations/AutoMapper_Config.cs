using DevClinic.Manager.Mappings.Clients;

namespace DevClinic.API.Configurations
{
    public static class AutoMapper_Config
    {
        public static void AddAutoMapperConfiguration(this IServiceCollection services)
        {
            services.AddAutoMapper(
                typeof(CreateClient_Mapping),
                typeof(UpdateClient_Mapping));
        }
    }
}
