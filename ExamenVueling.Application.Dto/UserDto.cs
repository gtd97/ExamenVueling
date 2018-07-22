using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenVueling.Application.Dto
{
    public class UserDto
    {
        public string nombre { get; set; }
        public string email { get; set; }
        public string role { get; set; }

        public UserDto() { }

        public UserDto(string nombre, string email, string role)
        {
            this.nombre = nombre;
            this.email = email;
            this.role = role;
        }
    }
}
