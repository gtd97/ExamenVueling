using ExamenVueling.Common.Layer;
using ExamenVueling.Domain.Models;
using ExamenVueling.Infrastructure.Repository.Contracts;
using ExamenVueling.Infrastructure.Repository.Mappers;
using log4net;
using System;
using System.Collections.Generic;
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
        private static readonly ILog Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        

        public List<ClientsEntity> Add(List<ClientsEntity> listaModelos)
        {
            try
            {
                XDocument DocXML = XDocument.Load("DocXML.xml");


                return listaModelos;
            }
            catch (VuelingExceptions ex)
            {
                Log.Error(ex);
                throw new VuelingExceptions(ResourceMessage.DbUpdateConcurrencyException, ex);
            }

        }

        public List<ClientsEntity> GetAll()
        {

            throw new NotImplementedException();
        }

        public ClientsEntity GetById(int id)
        {
            throw new NotImplementedException();
        }

        public ClientsEntity GetByName(string name)
        {
            throw new NotImplementedException();
        }
    }
}
