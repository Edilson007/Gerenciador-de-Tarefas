using GerenciamentoTarefas.Entities.DTO;
using GerenciamentoTarefas.Interfaces.IService;
using GerenciamentoTarefas.Validation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GerenciamentoTarefas.WebApi.Controllers
{
    [Route("api/tarefas")]
    [ApiController]
    public class TarefasController : ControllerBase
    {
        private readonly ITarefaService _tarefaService;

        public TarefasController(ITarefaService tarefaService)
        {
            _tarefaService = tarefaService;
        }

        [HttpGet("{tarefaId}")]
        public IActionResult Get([FromRoute] int tarefaId)
        {
            try
            {
                var result = _tarefaService.GetById(tarefaId);
                return Ok(result);


            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Erro ao buscar a tarefa: {ex.Message}");
            }
           
           
        }

        [HttpGet()]
        public IActionResult GetAll()
        {
            try
            {
                var tarefasList = _tarefaService.GetAll();
                return Ok(tarefasList);
                      
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Erro ao Buscar as tarefas: {ex.Message}");
            }
            

        }

        [HttpPost()]
        public IActionResult Post([FromBody] TarefaDTO paramDTO)
        {

            try
            {
                paramDTO.DataCriacao = DateTime.Now;
                var validate = new TarefaCreateValidator();
                var validatorResults = validate.Validate(paramDTO);
                
                if (validatorResults.IsValid)
                {
                    var result = _tarefaService.Add(paramDTO);
                    return Ok(result);
                }
                else
                {
                    return BadRequest(validatorResults);
                }

            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Erro ao criar a tarefa: {ex.Message}");
            }
           
        }

        [HttpPut]
        public IActionResult Put([FromBody] TarefaDTO paramDTO)
        {

            try
            {
                var validate = new TarefaUpdateValidator();
                var validatorResults = validate.Validate(paramDTO);

                if (validatorResults.IsValid)
                {
                    var result = _tarefaService.Update(paramDTO);
                    return Ok(result);
                }
                else
                {
                    return BadRequest(validatorResults);
                }

            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Erro ao atualizar a tarefa: {ex.Message}");
            }

        }

        [HttpDelete("{tarefaId}")]
        public IActionResult Delete([FromRoute] int tarefaId)
        {
            try
            {

                var tarefaExistente = _tarefaService.GetById(tarefaId);
                if (tarefaExistente == null)
                {
                    return NotFound("Tarefa não encontrada.");
                }

                _tarefaService.Delete(tarefaId);
                return NoContent();


            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Erro ao excluir a tarefa: {ex.Message}");
            }
           
        }
    }
}
