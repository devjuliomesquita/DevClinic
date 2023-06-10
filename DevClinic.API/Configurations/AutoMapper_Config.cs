using DevClinic.Manager.Mappings.Clients;
using DevClinic.Manager.Mappings.Doctors;
using DevClinic.Manager.Mappings.Specialities;

namespace DevClinic.API.Configurations
{
    public static class AutoMapper_Config
    {
        public static void AddAutoMapperConfiguration(this IServiceCollection services)
        {
            services.AddAutoMapper(
                typeof(CreateClient_Mapping), typeof(UpdateClient_Mapping),
                typeof(CreateDoctor_Mapping), typeof(UpdateDoctor_Mapping), typeof(DoctorView_Mapping),
                typeof(CreateSpeciality_Mapping), typeof(UpdateSpeciality_Mapping), typeof(SpecialityView_Mapping)
                );
        }
    }
}
