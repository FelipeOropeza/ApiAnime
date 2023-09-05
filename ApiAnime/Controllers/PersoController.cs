using ApiAnime.Models;
using ApiAnime.Repositorios.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiAnime.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersoController : ControllerBase
    {
        private readonly IPersoRepositorio _persoRepositorio;

        public PersoController(IPersoRepositorio persoRepositorio)
        {
            _persoRepositorio = persoRepositorio;
        }

        [HttpGet]
        public async Task<ActionResult<List<PersoModel>>> BuscarTodosPerso()
        {
            List<PersoModel> persos = await _persoRepositorio.BuscarTodosPerso();
            return Ok(persos);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<PersoModel>> BuscarPorId(int id)
        {
            PersoModel perso = await _persoRepositorio.BuscarPorId(id);
            return Ok(perso);
        }

        [HttpPost]
        public async Task<ActionResult<PersoModel>> Adicionar([FromBody] PersoModel persoModel)
        {
            PersoModel perso = await _persoRepositorio.Adicionar(persoModel);
            return Ok(perso);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<PersoModel>> Atualizar([FromBody] PersoModel persoModel, int id)
        {
            persoModel.Id = id;
            PersoModel perso = await _persoRepositorio.Atualizar(persoModel, id);
            return Ok(perso);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<PersoModel>> Apagar(int id)
        {
            bool apagado = await _persoRepositorio.Apagar(id);
            return Ok(apagado);
        }
    }
}
