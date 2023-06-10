using DevClinic.Domain.DTO.Speciality;
using DevClinic.Domain.Entities;
using DevClinic.Manager.Interfaces.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DevClinic.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SpecialityController : ControllerBase
    {
        private readonly ISpecialityService _specialityService;
        public SpecialityController(ISpecialityService specialityService)
        {
            _specialityService = specialityService;
        }
        /// <summary>
        /// Retorna uma lista de especialidades.
        /// </summary>
        [HttpGet]
        [ProducesResponseType(typeof(Speciality_ViewModel), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetAll()
        {
            return
                Ok(await _specialityService.GetAllAsync());
        }
        /// <summary>
        /// Retorna o objeto de especialidade com seus detalhes.
        /// </summary>
        /// <param name="id" example="2">Id da especialidade.</param>
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(Speciality_ViewModel), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetById(int id) 
        {
            return
                Ok(await _specialityService.GetSpecialityByIdAsync(id));
        }
        /// <summary>
        /// Excluir especialidade pelo Id.
        /// </summary>
        /// <param name="id" example="2">Id da especialidade.</param>
        [HttpDelete("{id}")]
        [ProducesResponseType(typeof(Speciality_ViewModel), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Delete(int id)
        {
            await _specialityService.DeleteAsync(id);
            return
                NoContent();
        }
        /// <summary>
        /// Inserir uma nova espcialidade.
        /// </summary>
        /// <param name="inputModel"></param>
        [HttpPost]
        [ProducesResponseType(typeof(Speciality_ViewModel), StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Create(CreateSpeciality_InputModel inputModel)
        {
            var createSpeciality = await _specialityService.AddAsync(inputModel);
            return
                CreatedAtAction(nameof(GetById), new { id = createSpeciality.Id}, createSpeciality);
        }
        /// <summary>
        /// Atualizar os dados de uma espcialidade.
        /// </summary>
        /// <param name="inputModel"></param>
        [HttpPut]
        [ProducesResponseType(typeof(Speciality_ViewModel), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Update(UpdateSpeciality_InputModel inputModel)
        {
            var specialityUpdate = await _specialityService.UpdateAsync(inputModel);
            if (specialityUpdate == null) { return NotFound(); }
            return
                Ok(specialityUpdate);
        }

    }
}
