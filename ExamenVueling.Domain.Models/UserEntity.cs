using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenVueling.Domain.Models
{
    public class UserEntity
    {
        public string nombre { get; set; }
        public string email { get; set; }
        public string role { get; set; }

        public UserEntity() { }

        public UserEntity(string nombre, string email, string role)
        {
            this.nombre = nombre;
            this.email = email;
            this.role = role;
        }
    }
}
