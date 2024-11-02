using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoTarefas.Repository.Conversion
{
    public static class EnumConverter
    {
        public static ValueConverter<T, char> EnumToCharConverter<T>() where T : Enum
        {
            return new ValueConverter<T, char>(enumerate => (char)Convert.ChangeType(enumerate, typeof(char)), value => (T)Enum.ToObject(typeof(T), value));
        }
    }
}
