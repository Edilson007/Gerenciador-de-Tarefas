using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoTarefas.Interfaces.IRepository
{
    public interface IBaseRepository<T> where T : class
    {
        IList<T> GetAll();
        T FindById(params object[] id);
        T Insert(T entity);
        T Update(T entity);
        void Delete(T entity);
    }

}
