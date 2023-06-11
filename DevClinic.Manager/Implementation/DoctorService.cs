using AutoMapper;
using DevClinic.Domain.DTO.Doctor;
using DevClinic.Domain.Entities;
using DevClinic.Manager.Interfaces.Repository;
using DevClinic.Manager.Interfaces.Services;


namespace DevClinic.Manager.Implementation
{
    public class DoctorService : ServiceBase<Doctor>, IDoctorService
    {
        private readonly IMapper _mapper;
        private readonly IDoctorRepository _repository;
        public DoctorService(IMapper mapper, IRepositoryBase<Doctor> repositoryBase, IDoctorRepository repository) : base(mapper, repositoryBase)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public async Task<Doctor_ViewModel> AddDoctorAsync<CreateDoctor_InputModel>(CreateDoctor_InputModel inputModel) 
            where CreateDoctor_InputModel : class
        {
            var doctor = _mapper.Map<Doctor>(inputModel);
            return
                _mapper.Map<Doctor_ViewModel>(await _repository.CreateDoctorAsync(doctor));
        }

        public async Task<Doctor_ViewModel> GetDoctortByIdAsync(int id)
        {
            return
                _mapper.Map<Doctor_ViewModel>(await _repository.GetDoctorByIdAsync(id));
        }

        public async Task<IEnumerable<Doctor_ViewModel>> GetAllDoctorsAsync()
        {
            return
                _mapper.Map<IEnumerable<Doctor>, IEnumerable<Doctor_ViewModel>>(await _repository.GetAllDoctorsAsync());
        }

        public async Task<Doctor_ViewModel> UpdateDoctorAsync<UpdateDoctor_InputModel>(UpdateDoctor_InputModel inputModel) 
            where UpdateDoctor_InputModel : class
        {
            var doctor = _mapper.Map<Doctor>(inputModel);
            return
                _mapper.Map<Doctor_ViewModel>(await _repository.UpdateDoctorAync(doctor));
        }

        
    }
}
