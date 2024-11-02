using GerenciamentoTarefas.Entities.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoTarefas.Interfaces.IService
{
    public interface ITarefaService
    {
        List<TarefaDTO> GetAll();
        TarefaDTO GetById(int tarefaId);
        TarefaDTO Add(TarefaDTO tarefaDTO);
        TarefaDTO Update(TarefaDTO tarefaDTO);
        void Delete(int id);
    }
}
