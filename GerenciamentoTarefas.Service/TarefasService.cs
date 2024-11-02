using GerenciamentoTarefas.Entities.DTO;
using GerenciamentoTarefas.Interfaces.IRepository;
using GerenciamentoTarefas.Interfaces.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using GerenciamentoTarefas.Entities.Entity;

namespace GerenciamentoTarefas.Service
{
    public class TarefasService : ITarefaService
    {
        private readonly IMapper _mapper;
        private readonly ITarefaRepository _tarefaRepository;

        public TarefasService(IMapper mapper, ITarefaRepository tarefaRepository)
        {
            _tarefaRepository = tarefaRepository;
            _mapper = mapper;
        }

        public TarefaDTO Add(TarefaDTO tarefaDTO)
        {
            try
            {
                var entity = _mapper.Map<Tarefa>(tarefaDTO);
                var result = _tarefaRepository.Insert(entity);
                return _mapper.Map<TarefaDTO>(result);

            }
            catch(Exception ex)
            {
                return null;
            }
        }

        public List<TarefaDTO> GetAll()
        {
            try
            {
                var tarefasList = _tarefaRepository.GetAll();
                return _mapper.Map<List<TarefaDTO>>(tarefasList);
            }
            catch (Exception ex) 
            {
                return null;
            }
        }

        public TarefaDTO GetById(int tarefaId)
        {
            try
            {
                var entity = _tarefaRepository.FindById(tarefaId);
                return _mapper.Map<TarefaDTO>(entity);
            }
            catch(Exception ex)
            {
                return null;
            }
        }

        public TarefaDTO Update(TarefaDTO tarefaDTO)
        {
            try
            {
                var entity = _mapper.Map<Tarefa>(tarefaDTO);
                var result = _tarefaRepository.Update(entity);
                return _mapper.Map<TarefaDTO>(result);

            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public void Delete(int id)
        {
            try
            {
                var entity = _tarefaRepository.FindById(id);
                _tarefaRepository.Delete(entity);

            }
            catch (Exception ex)
            {
                _ = ex.Message;
            }
        }
    }

}
