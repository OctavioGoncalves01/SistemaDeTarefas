using SistemaTarefasUsuarios.Models;

namespace SistemaTarefasUsuarios.Repositorios.Interface
{
    public interface IUsuarioRepositorio
    {
        Task<List<UsuarioModel>> BuscarTodosUsuarios();
        Task<UsuarioModel> BuscarUsuarioPorId(int id);
        Task <UsuarioModel> Adicionar(UsuarioModel usuario);
        Task<UsuarioModel> Atualizar(UsuarioModel usuario, int id);
        Task<bool> Apagar(int id);
    }
}