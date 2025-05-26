using ContratAi.Application.Dtos.Evento;
using ContratAi.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ContratAi.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EventoController : ControllerBase
    {
        private readonly IEventoAppService _eventoAppService;

        public EventoController(IEventoAppService eventoAppService)
        {
            _eventoAppService = eventoAppService;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var evento = await _eventoAppService.ListarEventoPorId(id);

            if(evento == null)
                return NotFound($"Evento de ID {id} não encontrado.");

            return Ok(evento);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] AdicionaEventoInput evento)
        {
            var id = await _eventoAppService.CadastraEvento(evento);
            return CreatedAtAction(nameof(GetById), new { id }, id);
        }

        [HttpPut]
        public async Task<IActionResult> Put([FromBody] AtualizaEventoInput evento)
        {
            await _eventoAppService.AtualizaEvento(evento);
            
            return NoContent();
        }

        [HttpDelete]
        public async Task<IActionResult> Delete([FromQuery] Guid Id)
        {
            await _eventoAppService.DeletaEvento(Id);
            return NoContent();
        }
    }
}
