
using DevClinic.Domain.DTO.Clients;
using DevClinic.Domain.Entities;
using DevClinic.Manager.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace DevClinic.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly IClientService _clientService;
        public ClientController(IClientService clientService)
        {
            _clientService = clientService;
        }
        /// <summary>
        /// Retorna a lista de clientes cadastrado na base de dados.
        /// </summary>
        [HttpGet]
        [ProducesResponseType(typeof(Client), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetAll() 
        {
            return
                Ok(await _clientService.GetAllAsync());
        }
        /// <summary>
        /// Retorna um cliente que é buscado pelo ID.
        /// </summary>
        /// <param name="id" example="2">Id do cliente.</param>
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(Client), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetById(int id)
        {
            return
                Ok(await _clientService.GetByIdAsync(id));
        }
        /// <summary>
        /// Excluir cliente pelo ID.
        /// </summary>
        /// <param name="id" example="2">Id do CLiente.</param>
        /// <remarks>Ao excluir um cliente o mesmo será removido permanentemente da base de dados.</remarks>
        [HttpDelete("{id}")]
        [ProducesResponseType(typeof(Client), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Delete(int id)
        {
            await _clientService.DeleteAsync(id);
            return NoContent();
        }
        /// <summary>
        /// Inserir um novo cliente.
        /// </summary>
        /// <param name="inputModel"></param>
        [HttpPost]
        [ProducesResponseType(typeof(Client), StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Create(CreateClient_InputModel inputModel)
        {
            var clientNew = await _clientService.AddAsync(inputModel);
            return
                CreatedAtAction(nameof(GetById), new {id = clientNew.Id}, clientNew);
                
        }
        /// <summary>
        /// Atualizãr os dados cadastratis de um novo cliente.
        /// </summary>
        /// <param name="inputModel"></param>
        [HttpPut]
        [ProducesResponseType(typeof(Client), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Update(UpdateClient_InputModel inputModel)
        {
            var clientUpdate = await _clientService.UpdateAsync(inputModel);
            if (clientUpdate == null) return NotFound();
            return
                Ok(clientUpdate);
        }

    }
}
