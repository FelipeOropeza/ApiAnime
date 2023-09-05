using ApiAnime.Data;
using ApiAnime.Models;
using ApiAnime.Repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ApiAnime.Repositorios
{
    public class PoderRepositorio : IPoderRepositorio
    {
        private readonly ApiPersoDBContex _dBContex;
        public PoderRepositorio(ApiPersoDBContex apiDBContex)
        {
            _dBContex = apiDBContex;
        }

        public async Task<PoderModel> BuscarPorId(int id)
        {
            return await _dBContex.Poders.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<List<PoderModel>> BuscarTodosPoder()
        {
            return await _dBContex.Poders.ToListAsync();
        }

        public async Task<PoderModel> Adicionar(PoderModel poder)
        {
            await _dBContex.Poders.AddAsync(poder);
            await _dBContex.SaveChangesAsync();

            return poder;
        }

        public async Task<PoderModel> Atualizar(PoderModel poder, int id)
        {
            PoderModel poderPorId = await BuscarPorId(id);

            if (poderPorId == null)
            {
                throw new Exception($"Poder para o ID: {id} não foi encontrado no banco de dados");
            }

            poderPorId.Resp = poder.Resp;

            _dBContex.Poders.Update(poderPorId);
            await _dBContex.SaveChangesAsync();

            return poderPorId;
        }

        public async Task<bool> Apagar(int id)
        {
            PoderModel poderPorId = await BuscarPorId(id);

            if (poderPorId == null)
            {
                throw new Exception($"Poder para o ID: {id} não foi encontrado no banco de dados");
            }

            _dBContex.Poders.Remove(poderPorId);
            await _dBContex.SaveChangesAsync();
            return true;
        }
    }
}
