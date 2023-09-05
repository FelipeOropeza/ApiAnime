using ApiAnime.Models;
using ApiAnime.Repositorios.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiAnime.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FuncController : ControllerBase
    {
        private readonly IFuncRepositorio _funcRepositorio;

        public FuncController(IFuncRepositorio funcRepositorio)
        {
            _funcRepositorio = funcRepositorio;
        }

        [HttpGet]
        public async Task<ActionResult<List<FuncModel>>> BuscarTodosFunc()
        {
            List<FuncModel> funcs = await _funcRepositorio.BuscarTodosFunc();
            return Ok(funcs);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<FuncModel>> BuscarPorId(int id)
        {
            FuncModel funcs = await _funcRepositorio.BuscarPorId(id);
            return Ok(funcs);
        }

        [HttpPost]
        public async Task<ActionResult<FuncModel>> Adicionar([FromBody] FuncModel funcModel)
        {
            FuncModel func = await _funcRepositorio.Adicionar(funcModel);
            return Ok(func);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<FuncModel>> Atualizar([FromBody] FuncModel funcModel, int id)
        {
            funcModel.Id = id;
            FuncModel func = await _funcRepositorio.Atualizar(funcModel, id);
            return Ok(func);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<FuncModel>> Apagar(int id)
        {
            bool apagado = await _funcRepositorio.Apagar(id);
            return Ok(apagado);
        }
    }
}
