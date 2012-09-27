using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lambda_delegatePrj
{
    public class Repository<T> where T : class, new()
    {
        private List<T> list;


        public Repository()
        {
            list  = new List<T>();
        }

        public void Add(T item)
        {
            list.Add(item);
        }

        public IEnumerable<T> Query(Func<T, bool> filter)
        {
            return list.Where(filter);
        }

        public T GetLastIn()
        {
            if (list.Count == 0)
            {
                return new T();
            }
            return list.Last();
        }
    }




    
}
