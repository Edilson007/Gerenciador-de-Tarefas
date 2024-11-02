using GerenciamentoTarefas.Entities.Entity;
using GerenciamentoTarefas.Interfaces.IRepository;
using GerenciamentoTarefas.Repository.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoTarefas.Repository.Repositories
{
    public class TarefaRepository : BaseRepository<Tarefa>, ITarefaRepository
    {
        private readonly GerenciadorTarefasEFContext _context;
        public TarefaRepository(GerenciadorTarefasEFContext context) : base(context)
        {
            _context = context;
        }
    }
}
