using ApiAnime.Data;
using ApiAnime.Models;
using ApiAnime.Repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ApiAnime.Repositorios
{
    public class FuncRepositorio : IFuncRepositorio
    {
        private readonly ApiPersoDBContex _dBContex;
        public FuncRepositorio(ApiPersoDBContex apiDBContex)
        {
            _dBContex = apiDBContex;
        }

        public async Task<FuncModel> BuscarPorId(int id)
        {
            return await _dBContex.Funcs.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<List<FuncModel>> BuscarTodosFunc()
        {
            return await _dBContex.Funcs.ToListAsync();
        }

        public async Task<FuncModel> Adicionar(FuncModel func)
        {
            await _dBContex.Funcs.AddAsync(func);
            await _dBContex.SaveChangesAsync();

            return func;
        }

        public async Task<FuncModel> Atualizar(FuncModel func, int id)
        {
            FuncModel funcPorId = await BuscarPorId(id);

            if (funcPorId == null)
            {
                throw new Exception($"Func para o ID: {id} não foi encontrado no banco de dados");
            }

            funcPorId.TipoFunc = func.TipoFunc;

            _dBContex.Funcs.Update(funcPorId);
            await _dBContex.SaveChangesAsync();

            return funcPorId;
        }

        public async Task<bool> Apagar(int id)
        {
            FuncModel funcPorId = await BuscarPorId(id);

            if (funcPorId == null)
            {
                throw new Exception($"Func para o ID: {id} não foi encontrado no banco de dados");
            }

            _dBContex.Funcs.Remove(funcPorId);
            await _dBContex.SaveChangesAsync();
            return true;
        }
    }
}
