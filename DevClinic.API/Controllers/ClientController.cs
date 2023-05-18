using DevClinic.API.DTO.InputModels.Client;
using DevClinic.API.DTO.ViewModels.Client;
using DevClinic.Domain.Interfaces.Services;
using DevClinic.Services.Validators;
using Microsoft.AspNetCore.Http;
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
        [HttpGet]
        public IActionResult GetAll() 
        {
            return
                Execute(() => _clientService.GetAll<Client_ViewModel>());
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            if (id == 0) return NotFound();
            return
                Execute(() => _clientService.GetById<ClientStandard_ViewModel>(id));
        }
        [HttpGet("{id}/Details")]
        public IActionResult GetDetails(int id)
        {
            if (id == 0) return NotFound();
            return
                Execute(() => _clientService.GetDetails<ClientDetails_ViewModel>(id));
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (id == 0) return NotFound();
            Execute(() =>
            {
                _clientService.Delete(id);
                return true;
            });
            return new ContentResult();
        }
        [HttpPost]
        public IActionResult Create([FromBody] ClientCreate_InputModel inputModel)
        {
            if (inputModel == null) return NoContent();
            return
                Execute(() => _clientService.Add<ClientCreate_InputModel, Client_ViewModel, ClientValidator>(inputModel));
        }
        [HttpPut]
        public IActionResult Update([FromBody] ClientUpdate_InputModel inputModel)
        {
            if (inputModel == null) return NoContent();
            return
                Execute(() => _clientService.Update<ClientUpdate_InputModel, Client_ViewModel, ClientValidator>(inputModel));
        }
        

        //Criando o Método de execução
        private IActionResult Execute(Func<object> func)
        {
            try
            {
                var result = func();
                return Ok(result);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
    }
}
