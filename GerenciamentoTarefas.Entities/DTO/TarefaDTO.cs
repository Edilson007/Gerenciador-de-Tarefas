using GerenciamentoTarefas.Entities.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoTarefas.Entities.DTO
{
    public class TarefaDTO
    {
        public int? TarefaId { get; set; }
        public string? Titulo { get; set; }
        public string? Descricao { get; set; }
        public DateTime? DataCriacao { get; set; }
        public DateTime? DataConclusao { get; set; }
        public StatusEnum Status { get; set; }
    }
}
