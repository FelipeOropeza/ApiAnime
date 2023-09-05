using ApiAnime.Models;

namespace ApiAnime.Repositorios.Interfaces
{
    public interface IPoderRepositorio
    {
        Task<List<PoderModel>> BuscarTodosPoder();
        Task<PoderModel> BuscarPorId(int id);
        Task<PoderModel> Adicionar(PoderModel poder);
        Task<PoderModel> Atualizar(PoderModel poder, int id);
        Task<bool> Apagar(int id);
    }
}
