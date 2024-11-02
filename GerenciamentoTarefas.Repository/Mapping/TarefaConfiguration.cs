using GerenciamentoTarefas.Entities.Entity;
using GerenciamentoTarefas.Entities.Enum;
using GerenciamentoTarefas.Repository.Conversion;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoTarefas.Repository.Mapping
{
    public class TarefaConfiguration : IEntityTypeConfiguration<Tarefa>
    {
        public void Configure(EntityTypeBuilder<Tarefa> builder)
        {
            builder.ToTable("TAREFA");

            builder.HasKey(t => t.TarefaId).HasName("ID_TAREFA");

            builder.Property(t => t.TarefaId).HasColumnName("TAREFA_ID");
            builder.Property(t => t.Titulo).HasColumnName("TITULO").HasColumnType("nvarchar(100)").IsRequired();
            builder.Property(t => t.Descricao).HasColumnName("DESCRICAO").HasColumnType("nvarchar(MAX)");
            builder.Property(t => t.DataCriacao).HasColumnName("DATA_CRIACAO").HasColumnType("date");
            builder.Property(t => t.DataConclusao).HasColumnName("DATA_CONCLUSAO").HasColumnType("date");
            builder.Property(t => t.Status).HasColumnName("STATUS").HasColumnType("nchar(1)").HasConversion(EnumConverter.EnumToCharConverter<StatusEnum>());
        }
    }
}
