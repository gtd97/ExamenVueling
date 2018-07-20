using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenVueling.Infrastructure.Repository.Contracts
{
    public interface IRepository<T>
    {
        List<T> GetAll();
        T GetById(int id);
        T GetByName(string name);
        T Add(T model);
    }
}
