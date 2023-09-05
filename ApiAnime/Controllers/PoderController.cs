using ApiAnime.Models;
using ApiAnime.Repositorios.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiAnime.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PoderController : ControllerBase
    {
        private readonly IPoderRepositorio _poderRepositorio;

        public PoderController(IPoderRepositorio poderRepositorio)
        {
            _poderRepositorio = poderRepositorio;
        }

        [HttpGet]
        public async Task<ActionResult<List<PoderModel>>> BuscarTodosPoder()
        {
            List<PoderModel> poders = await _poderRepositorio.BuscarTodosPoder();
            return Ok(poders);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<PoderModel>> BuscarPorId(int id)
        {
            PoderModel poder = await _poderRepositorio.BuscarPorId(id);
            return Ok(poder);
        }

        [HttpPost]
        public async Task<ActionResult<PoderModel>> Adicionar([FromBody] PoderModel poderModel)
        {
            PoderModel poder = await _poderRepositorio.Adicionar(poderModel);
            return Ok(poder);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<PoderModel>> Atualizar([FromBody] PoderModel poderModel, int id)
        {
            poderModel.Id = id;
            PoderModel poder = await _poderRepositorio.Atualizar(poderModel, id);
            return Ok(poder);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<PoderModel>> Apagar(int id)
        {
            bool apagado = await _poderRepositorio.Apagar(id);
            return Ok(apagado);
        }
    }
}
