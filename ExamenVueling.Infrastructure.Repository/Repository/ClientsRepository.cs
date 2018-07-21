using ExamenVueling.Common.Layer;
using ExamenVueling.Domain.Models;
using ExamenVueling.Infrastructure.Repository.Contracts;
using ExamenVueling.Infrastructure.Repository.Mappers;
using log4net;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ExamenVueling.Infrastructure.Repository.Repository
{
    public class ClientsRepository : IRepository<ClientsEntity>
    {
        //private static readonly ILog Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        

        public ClientsEntity Add(ClientsEntity modelo)
        {
            try
            {
                XDocument DocXML = XDocument.Load("DocXML.xml");
                
                return modelo;
            }
            catch (VuelingExceptions ex)
            {
                //Log.Error(ex);
                throw new VuelingExceptions(ResourceMessage.DbUpdateConcurrencyException, ex);
            }

        }

        public List<ClientsEntity> GetAll()
        {
            List<ClientsEntity> listaClients = new List<ClientsEntity>();

            XDocument xml = XDocument.Load(ConfigurationManager.AppSettings.Get("XmlClients"));
            
            var clients = from clientes in xml.Descendants("Clients")
                          from client in clientes.Elements("Client")
                          select new { id = client.Attribute("Id").Value, nombre = client.Element("Nombre").FirstNode, email = client.Element("Email").FirstNode, role = client.Element("Role").FirstNode };

            foreach (var client in clients)
            {
                ClientsEntity clientNew = new ClientsEntity(client.id, client.nombre.ToString(), client.email.ToString(), client.role.ToString());
                listaClients.Add(clientNew);
            }

            return listaClients;
        }

        public ClientsEntity GetById(string id)
        {
            XDocument xml = XDocument.Load(ConfigurationManager.AppSettings.Get("XmlClients"));
            
            var clients = from clientes in xml.Descendants("Clients")
                          from client in clientes.Elements("Client")
                          where client.Attribute("Id").Value == id
                          select new { id = client.Attribute("Id").Value, nombre = client.Element("Nombre").FirstNode, email = client.Element("Email").FirstNode, role = client.Element("Role").FirstNode };

            ClientsEntity clientFind = null;

            foreach (var client in clients)
            {
                clientFind = new ClientsEntity(client.id, client.nombre.ToString(), client.email.ToString(), client.role.ToString());
            }

            return clientFind;
        }

        public ClientsEntity GetByName(string name)
        {
            throw new NotImplementedException();
        }
    }
}
