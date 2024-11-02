using AutoMapper;
using GerenciamentoTarefas.Entities.DTO;
using GerenciamentoTarefas.Entities.Entity;
using GerenciamentoTarefas.Extension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoTarefas.AutoMapper
{
    public class DTOToEntityMapper : Profile
    {
        public DTOToEntityMapper()
        {
            CreateMap<TarefaDTO, Tarefa>()
                .ForMember(target => target.Titulo, source => source.MapFrom(result => result.Titulo))
                .ForMember(target => target.Descricao, source => source.MapFrom(result => result.Descricao))
                .ForMember(target => target.DataCriacao, source => source.MapFrom(result => result.DataCriacao))
                .ForMember(target => target.DataConclusao, source => source.MapFrom(result => result.DataConclusao))
                .ForMember(target => target.Status, source => source.MapFrom(result => EnumExtension.GetDefaultValue(result.Status).ToString()));
        }
    }
}
