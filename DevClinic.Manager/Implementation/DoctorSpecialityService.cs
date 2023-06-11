using AutoMapper;
using DevClinic.Domain.DTO.Doctor;
using DevClinic.Domain.Entities;
using DevClinic.Manager.Interfaces.Repository;
using DevClinic.Manager.Interfaces.Services;


namespace DevClinic.Manager.Implementation
{
    public class DoctorSpecialityService : IDoctorSpecialityService
    {
        private readonly IDoctorSpecialityRepository _doctorSpecRepository;
        private readonly IMapper _mapper;
        public DoctorSpecialityService(IDoctorSpecialityRepository doctorSpecRepository, IMapper mapper)
        {
            _doctorSpecRepository = doctorSpecRepository;
            _mapper = mapper;
        }

        public async Task<DoctorSpeciality> AddSpecDoctorAsync<CreateSpecialityDoctor_InputModel>(CreateSpecialityDoctor_InputModel inputModel) 
            where CreateSpecialityDoctor_InputModel : class
        {
            var entity = _mapper.Map<DoctorSpeciality>(inputModel);
            var doctorSpec = await _doctorSpecRepository.GetSpecialityDoctorAsync(entity);
            if (doctorSpec != null) return null;
            await _doctorSpecRepository.AddAsync(entity);
            return entity;
        }

        public async Task DeleteSpecDoctorAsync(CreateSpecialityDoctor_InputModel inputModel)
        {
            var entity = _mapper.Map<DoctorSpeciality>(inputModel);
            var doctorSpec = await _doctorSpecRepository.GetSpecialityDoctorAsync(entity);
            if (doctorSpec != null)
            {
                await _doctorSpecRepository.DeleteAsync(doctorSpec);
            }
        }

        
    }
}
