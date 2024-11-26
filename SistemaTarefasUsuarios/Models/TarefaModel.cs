using SistemaTarefasUsuarios.Enum;

namespace SistemaTarefasUsuarios.Models
{
    public class TarefaModel
    {
        public int Id { get; set; }
        public string? NomeTarefa { get; set; }
        public string? Descricao { get; set; }
        public StatusTarefa Status { get; set; }
    }
}