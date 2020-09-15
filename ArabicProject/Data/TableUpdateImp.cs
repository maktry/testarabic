using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ArabicProject.Data
{
    public class TableUpdateImp<T> : ITableUpdate<T> where T : class
    {
        private readonly ApplicationDbContext _context;

        public TableUpdateImp(ApplicationDbContext context)
        {
            _context = context;
        }
        public void Add(T entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> Find(Expression<Func<T, bool>> predic)
        {
            return _context.Set<T>().Where(predic);
        }

        public T Get(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll()
        {
         return   _context.Set<T>().ToList();
            
        }

        public IList<T> ListTable(string Name)
        {
            throw new NotImplementedException();
        }
    }
}
