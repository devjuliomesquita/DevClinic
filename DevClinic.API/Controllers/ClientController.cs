
using DevClinic.Domain.DTO.Clients;
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
        [HttpGet]
        public async Task<IActionResult> GetAll() 
        {
            return
                Ok(await _clientService.GetAllAsync());
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            return
                Ok(await _clientService.GetByIdAsync(id));
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _clientService.DeleteAsync(id);
            return NoContent();
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateClient_InputModel inputModel)
        {
            var clientNew = await _clientService.AddAsync(inputModel);
            return
                CreatedAtAction(nameof(GetById), new {id = clientNew.Id}, clientNew);
                
        }
        [HttpPut]
        public async Task<IActionResult> Update(UpdateClient_InputModel inputModel)
        {
            var clientUpdate = await _clientService.UpdateAsync(inputModel);
            if (clientUpdate == null) return NotFound();
            return
                Ok(clientUpdate);
        }

    }
}
