using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenVueling.Application.Services.Contracts
{
    public interface IService<T>
    {
        T Add(T model);
        T Update(T model);
        List<T> GetAll();
        T GetById(Guid id);
        T GetById(string name);
    }
}
