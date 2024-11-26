using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SistemaTarefasUsuarios.Data;
using SistemaTarefasUsuarios.Models;
using SistemaTarefasUsuarios.Repositorios.Interface;


namespace SistemaTarefasUsuarios.Repositorios
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {

        private readonly SistemaTarefasDBContext _dbContext;
        public UsuarioRepositorio(SistemaTarefasDBContext sistemaTarefasDBContext){
            _dbContext = sistemaTarefasDBContext;
        }

        public async Task<UsuarioModel> Adicionar(UsuarioModel usuario)
        {
            await _dbContext.Usuarios.AddAsync(usuario);
            await _dbContext.SaveChangesAsync();
            return usuario;
        }

        public async Task<bool> Apagar(int id)
        {
            UsuarioModel usuarioPorId = await BuscarUsuarioPorId(id);

            if(usuarioPorId == null){
                throw new Exception($"Usuario para o id:{id} não foi encontrado no banco de dados.");

            }

            _dbContext.Usuarios.Remove(usuarioPorId);
            await _dbContext.SaveChangesAsync();

            return true;
        }

        public async Task<UsuarioModel> Atualizar(UsuarioModel usuario, int id)
        {
            UsuarioModel usuarioPorId = await BuscarUsuarioPorId(id);

            if(usuarioPorId == null){
                throw new Exception($"Usuario para o id:{id} não foi encontrado no banco de dados.");

            }
            usuarioPorId.NomeUsuario = usuario.NomeUsuario;
            usuarioPorId.Email = usuario.Email;

            _dbContext.Usuarios.Update(usuarioPorId);
            await _dbContext.SaveChangesAsync();

            return usuarioPorId;
        }

        public async Task<List<UsuarioModel>> BuscarTodosUsuarios()
        {
            return await _dbContext.Usuarios.ToListAsync();
        }

        public async Task<UsuarioModel> BuscarUsuarioPorId(int id)
        {  
            return await _dbContext.Usuarios.FirstOrDefaultAsync(x => x.Id == id);
            
        }
    }
}
