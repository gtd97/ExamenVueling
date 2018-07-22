using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenVueling.Application.Services.Contracts
{
    public interface IAuthenticationService<T>
    {
        T Authentication(string name, string email);
    }
}
