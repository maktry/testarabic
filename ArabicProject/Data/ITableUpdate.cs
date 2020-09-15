using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ArabicProject.Data
{
   public interface ITableUpdate<T> where T: class
    {
        T Get(int Id);
        IEnumerable<T> GetAll();
        IEnumerable<T> Find(Expression<Func<T, bool>> predic);

        void Add(T entity);


        public IList<T> ListTable(string Name);

    }
}
