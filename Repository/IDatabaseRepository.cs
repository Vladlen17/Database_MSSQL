using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Repository
{
    public interface IDatabaseRepository<T>
    {
        void Create(T entity);
        T GetById(int id);
        void Update(T entity);
        void Delete(int id);
    }
}
