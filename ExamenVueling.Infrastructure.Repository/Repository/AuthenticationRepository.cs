using ExamenVueling.Domain.Models;
using ExamenVueling.Infrastructure.Repository.Contracts;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ExamenVueling.Infrastructure.Repository.Repository
{
    public class AuthenticationRepository: IRepositoryAuthentication<UserEntity>
    {
        XDocument xmlClients;

        public UserEntity Authentication(string nombre, string email)
        {
            xmlClients = XDocument.Load(ConfigurationManager.AppSettings.Get("XmlClients"));
            
            var clients = from clientes in xmlClients.Descendants("Clients").Elements("Client")
                          where clientes.Element("Nombre").Value == nombre
                          where clientes.Element("Email").Value == email
                          select new {nombre = clientes.Element("Nombre").Value, email = clientes.Element("Email").Value, role = clientes.Element("Role").Value };

            UserEntity userNew = null;
            foreach (var client in clients)
            {
                userNew = new UserEntity(client.nombre.ToString(), client.email.ToString(), client.role.ToString());
            }

            return userNew;
        }
    }
}
