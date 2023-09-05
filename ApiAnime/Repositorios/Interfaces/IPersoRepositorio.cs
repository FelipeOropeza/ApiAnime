using ApiAnime.Models;

namespace ApiAnime.Repositorios.Interfaces
{
    public interface IPersoRepositorio
    {
        Task<List<PersoModel>> BuscarTodosPerso();
        Task<PersoModel> BuscarPorId(int id);
        Task<PersoModel> Adicionar(PersoModel perso);
        Task<PersoModel> Atualizar(PersoModel perso, int id);
        Task<bool> Apagar(int id);
    }
}
