using DevClinic.API.DTO.InputModels.Client;
using DevClinic.API.DTO.ViewModels.Client;
using DevClinic.Domain.Entities;
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
        public async Task<IActionResult> Create( Client inputModel)
        {
            var clientNew = await _clientService.AddAsync(inputModel);
            return
                CreatedAtAction(nameof(GetById), new {id = inputModel.Id}, inputModel);
                
        }
        [HttpPut]
        public async Task<IActionResult> Update( Client inputModel)
        {
            var clientUpdate = await _clientService.UpdateAsync(inputModel);
            if (clientUpdate == null) return NotFound();
            return
                Ok(clientUpdate);
        }

    }
}
