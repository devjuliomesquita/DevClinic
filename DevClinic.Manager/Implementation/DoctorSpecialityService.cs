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
            //Mapear os dados
            var entity = _mapper.Map<DoctorSpeciality>(inputModel);
            //consultar id para saber se esse relacionameto já existe
            var doctorSpec = await _doctorSpecRepository.GetSpecialityDoctorAsync(entity);
            //relacionamento não existindo -> adicionadar a base.
            if (doctorSpec == null)
            {
                _doctorSpecRepository.AddAsync(entity);
            }
            return
                entity;
        }

        public Task DeleteSpecDoctorAsync(int id)
        {
            throw new NotImplementedException();
        }

        
    }
}
