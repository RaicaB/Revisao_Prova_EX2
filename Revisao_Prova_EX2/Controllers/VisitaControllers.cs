using Microsoft.AspNetCore.Mvc;
using Revisao_Prova_EX2.Models;
using Revisao_Prova_EX2.Repositories;

namespace Revisao_Prova_EX2.Controllers
{
    [ApiController]
    [Route("api/[controller]")] // Rota: /api/visitas
    public class VisitasController : ControllerBase
    {
        private readonly IVisitaRepository _repo; // Injeção de dependência

        public VisitasController(IVisitaRepository repo)
        {
            _repo = repo;
        }

        [HttpPost] // POST - registrar visita
        public IActionResult Post([FromBody] Visita visita)
        {
            if (!ModelState.IsValid) // Validações dos atributos
                return BadRequest(ModelState);

            _repo.Registrar(visita); // Registra visita
            return Ok("Visita registrada com sucesso!");
        }

        [HttpGet("{numeroProjeto}")] // GET - consultar visitas por projeto
        public IActionResult Get(int numeroProjeto)
        {
            return Ok(_repo.ConsultarPorProjeto(numeroProjeto)); // Retorna visitas do projeto
        }
    }
}
