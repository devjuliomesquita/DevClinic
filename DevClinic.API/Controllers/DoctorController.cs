using DevClinic.Domain.DTO.Doctor;
using DevClinic.Domain.DTO.Error;
using DevClinic.Manager.Interfaces.Services;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DevClinic.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorController : ControllerBase
    {
        private readonly IDoctorService _doctorService;
        private readonly IDoctorSpecialityService _doctorSpecService;
        public DoctorController(IDoctorService doctorService, IDoctorSpecialityService doctorSpecService)
        {
            _doctorService = doctorService;
            _doctorSpecService = doctorSpecService;
        }
        /// <summary>
        /// Retorna uma lista de médicos;
        /// </summary>
        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<Doctor_ViewModel>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetAll()
        {
            return
                Ok(await _doctorService.GetAllDoctorsAsync());
        }
        /// <summary>
        /// Retorna um médico detalhado.
        /// </summary>
        /// <param name="id" example="2">Id do médico.</param>
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(Doctor_ViewModel), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetById(int id) 
        {
            return
                Ok(await _doctorService.GetDoctortByIdAsync(id));
        }
        /// <summary>
        /// Excluir um médico pelo Id.
        /// </summary>
        /// <param name="id" example="2">Id do médico.</param>
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Delete(int id)
        {
            await _doctorService.DeleteAsync(id);
            return
                NoContent();
        }
        /// <summary>
        /// Inserir um novo médico
        /// </summary>
        /// <param name="inputModel"></param>
        [HttpPost]
        [ProducesResponseType(typeof(Doctor_ViewModel), StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Create(CreateDoctor_InputModel inputModel)
        {
            var doctorNew = await _doctorService.AddAsync(inputModel);
            return
                CreatedAtAction(nameof(GetById), new {Id = doctorNew.Id}, doctorNew);
        }
        /// <summary>
        /// Adicionar uma espcialidade no médico.
        /// </summary>
        /// <param name="inputModel"></param>
        [HttpPost("/add-Speciality")]
        [ProducesResponseType(typeof(Doctor_ViewModel), StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> AddSpecialityDoctor(CreateSpecialityDoctor_InputModel inputModel)
        {
            var doctorSpec = await _doctorSpecService.AddSpecDoctorAsync(inputModel);
            return
                Ok(await _doctorService.GetDoctortByIdAsync(doctorSpec.DoctorId));
            
        }
        /// <summary>
        /// Atualizar um médico.
        /// </summary>
        /// <param name="inputModel"></param>
        [HttpPut]
        [ProducesResponseType(typeof(Doctor_ViewModel), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Update(UpdateDoctor_InputModel inputModel)
        {
            var updateDoctor = await _doctorService.UpdateAsync(inputModel);
            if (updateDoctor == null) { return NotFound(); }
            return
                Ok(updateDoctor);
        }
    }
}
