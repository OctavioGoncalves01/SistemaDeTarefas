using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SistemaTarefasUsuarios.Models;
using SistemaTarefasUsuarios.Repositorios;
using SistemaTarefasUsuarios.Repositorios.Interface;

namespace SistemaTarefasUsuarios.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuarioController : ControllerBase
    {

        private readonly IUsuarioRepositorio _usuarioRepositorio;

        public UsuarioController(IUsuarioRepositorio usuarioRepositorio)
        {
            _usuarioRepositorio = usuarioRepositorio;
        }

        [HttpGet]
        public async Task<ActionResult<List<UsuarioModel>>> BuscarTodosUsuario(){

            List<UsuarioModel> usuarios = await _usuarioRepositorio.BuscarTodosUsuarios();
            return Ok(usuarios);
        }
    
        [HttpGet("{id}")]
        public async Task<ActionResult<UsuarioModel>> BuscarPorId(int id){
            UsuarioModel usuario = await _usuarioRepositorio.BuscarUsuarioPorId(id);
            return Ok(usuario);
        }

        [HttpPost]
        public async Task<ActionResult<UsuarioModel>> Cadastrar([FromBody] UsuarioModel usuarioModel){
            UsuarioModel usuario = await _usuarioRepositorio.Adicionar(usuarioModel);
            return Ok(usuario);
        }
    
        [HttpPut("{id}")]
        public async Task<ActionResult<UsuarioModel>> Atualizar([FromBody] UsuarioModel usuarioModel, int id){
            usuarioModel.Id = id;
            UsuarioModel usuario = await _usuarioRepositorio.Atualizar(usuarioModel, id);
            return Ok(usuario);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<UsuarioModel>> Apagar(int id){
            
            bool usuarioapagado = await _usuarioRepositorio.Apagar(id);
            return Ok(usuarioapagado);
        }
    
    
    }
}