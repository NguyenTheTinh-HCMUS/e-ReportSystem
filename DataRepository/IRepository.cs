using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataRepository
{
    public interface IRepository<T> where T:class
    {
        Task Create(T t);
        Task<int> Delete(T t);
        Task<IList<T>> Read();
        Task<int> Update(T t);
    }
}
