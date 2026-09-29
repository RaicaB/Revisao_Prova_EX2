using Microsoft.AspNetCore.Mvc;
using Revisao_Prova_EX2.Models;
using Revisao_Prova_EX2.Repositories;

namespace Revisao_Prova_EX2.Controllers
{
    [ApiController]
    [Route("api/[controller]")] // Rota: /api/projetos
    public class ProjetosController : ControllerBase
    {
        private readonly IProjetoRepository _repo; // Injeção de dependência

        public ProjetosController(IProjetoRepository repo)
        {
            _repo = repo;
        }

        [HttpPost] // POST - cadastrar projeto
        public IActionResult Post([FromBody] Projeto projeto)
        {
            if (!ModelState.IsValid) // Validações dos atributos
                return BadRequest(ModelState);

            try
            {
                _repo.Adicionar(projeto); // Adiciona projeto
                return Ok("Projeto cadastrado com sucesso!");
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message); // Retorna erro se número duplicado
            }
        }

        [HttpGet] // GET - listar projetos
        public IActionResult Get()
        {
            return Ok(_repo.Listar()); // Retorna lista de projetos
        }
    }
}
