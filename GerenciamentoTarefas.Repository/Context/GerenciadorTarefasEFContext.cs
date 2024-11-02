using GerenciamentoTarefas.Entities.Entity;
using GerenciamentoTarefas.Repository.Mapping;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoTarefas.Repository.Context
{
    public class GerenciadorTarefasEFContext : DbContext
    {
        public GerenciadorTarefasEFContext(DbContextOptions<GerenciadorTarefasEFContext> options) : base(options)
        {
            
        }


        public DbSet<Tarefa> Tarefas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new TarefaConfiguration());
        }


    }
}
