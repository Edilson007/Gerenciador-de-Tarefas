using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoTarefas.Extension
{
    public static class EnumExtension
    {
        public static object GetDefaultValue(this Enum value)
        {
            if (value is null || !Enum.IsDefined(value.GetType(), value))
                return null;

            DefaultValueAttribute[] enumValues = (DefaultValueAttribute[])
                value
                .GetType()
                .GetField(value.ToString())
                .GetCustomAttributes(typeof(DefaultValueAttribute), false);

            return (enumValues.Length > 0) ? enumValues[0].Value : null;
        }
    }
}
