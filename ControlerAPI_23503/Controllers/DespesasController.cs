using Microsoft.AspNetCore.Mvc;
using ControlerAPI_23503.Models;
using ControlerAPI_23503.Data;

namespace ControlerAPI_23503.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DespesasController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Despesa> Get() => RepositorioDespesa.PegarTodas();

        [HttpGet("{id}")]
        public Despesa? Get(int id) => RepositorioDespesa.PegarPorId(id);

        [HttpPost]
        public IActionResult Post([FromBody] Despesa despesa)
        {
            if (despesa == null) return BadRequest();
            despesa.Id = RepositorioDespesa.Despesas.Count + 1;
            RepositorioDespesa.Adicionar(despesa);
            return CreatedAtAction(nameof(Get), new { id = despesa.Id }, despesa);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            bool removido = RepositorioDespesa.Remover(id);

            if (!removido) return NotFound();

            return NoContent();
        }

    }
}