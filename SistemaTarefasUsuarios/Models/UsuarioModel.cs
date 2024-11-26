using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaTarefasUsuarios.Models
{
    public class UsuarioModel
    {
        public int Id { get; set; }
        public string? NomeUsuario { get; set; }
        public string? Email { get; set; }
    }
}