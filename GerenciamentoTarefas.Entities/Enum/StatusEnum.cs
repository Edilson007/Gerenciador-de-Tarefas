using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoTarefas.Entities.Enum
{
    public enum StatusEnum
    {
        [DefaultValue("Pendente")]
        Pendente = 'P',
        [DefaultValue("EmProgresso")]
        EmProgresso = 'E',
        [DefaultValue("Concluida")]
        Concluida = 'C'

    }
}
