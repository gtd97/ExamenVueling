using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenVueling.Domain.Models
{
    public class ClientsEntity
    {
        public System.Guid id { get; set; }
        public string nombre { get; set; }
        public string email { get; set; }
        public string role { get; set; }

        public ClientsEntity() { }

        public ClientsEntity(string nombre, string email, string role)
        {
            this.nombre = nombre;
            this.email = email;
            this.role = role;
        }

        public ClientsEntity(Guid id, string nombre, string email, string role)
        {
            this.id = id;
            this.nombre = nombre;
            this.email = email;
            this.role = role;
        }

    }
}
