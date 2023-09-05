using ApiAnime.Data;
using ApiAnime.Models;
using ApiAnime.Repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ApiAnime.Repositorios
{
    public class PersoRepositorio : IPersoRepositorio
    {
        private readonly ApiPersoDBContex _dBContex;
        public PersoRepositorio(ApiPersoDBContex apiPersoDBContex)
        {
            _dBContex = apiPersoDBContex;
        }

        public async Task<PersoModel> BuscarPorId(int id)
        {
            return await _dBContex.Persos
                .Include(x => x.Poder)
                .Include(x => x.Func)
                .FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<List<PersoModel>> BuscarTodosPerso()
        {
            return await _dBContex.Persos
                .Include(x => x.Poder)
                .Include(x => x.Func)
                .ToListAsync();
        }

        public async Task<PersoModel> Adicionar(PersoModel perso)
        {
            await _dBContex.Persos.AddAsync(perso);
            await _dBContex.SaveChangesAsync();

            return perso;
        }

        public async Task<PersoModel> Atualizar(PersoModel perso, int id)
        {
            PersoModel persoPorId = await BuscarPorId(id);

            if (persoPorId == null)
            {
                throw new Exception($"Personagem para o ID: {id} não foi encontrado no banco de dados");
            }

            persoPorId.Nome = perso.Nome;
            persoPorId.Origem = perso.Origem;
            persoPorId.Apelido = perso.Apelido;
            persoPorId.Metas = perso.Metas;
            persoPorId.PoderId = perso.PoderId;
            persoPorId.FuncId = perso.FuncId;

            _dBContex.Persos.Update(persoPorId);
            await _dBContex.SaveChangesAsync();

            return persoPorId;
        }

        public async Task<bool> Apagar(int id)
        {
            PersoModel persoPorId = await BuscarPorId(id);

            if (persoPorId == null)
            {
                throw new Exception($"Personagem para o ID: {id} não foi encontrado no banco de dados");
            }

            _dBContex.Persos.Remove(persoPorId);
            await _dBContex.SaveChangesAsync();
            return true;
        }
    }
}
