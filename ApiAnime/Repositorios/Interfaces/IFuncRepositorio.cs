using ApiAnime.Models;

namespace ApiAnime.Repositorios.Interfaces
{
    public interface IFuncRepositorio
    {
        Task<List<FuncModel>> BuscarTodosFunc();
        Task<FuncModel> BuscarPorId(int id);
        Task<FuncModel> Adicionar(FuncModel func);
        Task<FuncModel> Atualizar(FuncModel func, int id);
        Task<bool> Apagar(int id);
    }
}
