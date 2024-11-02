using FluentValidation;
using GerenciamentoTarefas.Entities.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoTarefas.Validation
{
    public class TarefaCreateValidator : AbstractValidator<TarefaDTO>
    {
        public TarefaCreateValidator()
        {
            RuleFor(o => o.Titulo)
                .NotEmpty().WithMessage("É obrigatório o preenchimento do campo título.")
                .MaximumLength(100).WithMessage("O campo título deve ter no máximo 100 caracteres.");

            RuleFor(o => o.DataConclusao)
                .GreaterThanOrEqualTo(o => o.DataCriacao)
                .WithMessage("A data de conclusão não pode ser anterior à data de criação.");
        }
    }
}
