using ExamenVueling.Common.Layer;
using ExamenVueling.Domain.Models;
using ExamenVueling.Infrastructure.Repository.Contracts;
using ExamenVueling.Infrastructure.Repository.DataModel;
using ExamenVueling.Infrastructure.Repository.Mappers;
using log4net;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenVueling.Infrastructure.Repository.Repository
{
    public class ClientsRepository : IRepository<ClientsEntity>
    {
        private static readonly ILog Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        ExamenVuelingEntities db = new ExamenVuelingEntities();

        public ClientsEntity Add(ClientsEntity model)
        {
            ClientsEntity clientesEntityAdded;

            // Aqui se haria el automapper para pasar a objeto 
            try
            {
                //Clients cliente = new Clients(model.id, model.nombre, model.email, model.role);
                Clients cliente = new Clients(model.id, model.nombre, model.email, model.role);

                db.Clients.Add(cliente);
                db.SaveChanges();

                clientesEntityAdded = MapperInfrastructureClients.ClientDataModelToClientEntity(cliente);
            }
            catch (DbUpdateConcurrencyException ex)
            {
                Log.Error(ex);
                throw new VuelingExceptions(ResourceMessage.DbUpdateConcurrencyException, ex);
            }
            catch (DbUpdateException ex)
            {
                Log.Error(ex);
                throw new VuelingExceptions(ResourceMessage.DbUpdateException, ex);
            }
            catch (DbEntityValidationException ex)
            {
                Log.Error(ex);
                throw new VuelingExceptions(ResourceMessage.DbEntityValidationException, ex);
            }
            catch (NotSupportedException ex)
            {
                Log.Error(ex);
                throw new VuelingExceptions(ResourceMessage.NotSupportedException, ex);
            }
            catch (ObjectDisposedException ex)
            {
                Log.Error(ex);
                throw new VuelingExceptions(ResourceMessage.ObjectDisposedException, ex);
            }
            catch (InvalidOperationException ex)
            {
                Log.Error(ex);
                throw new VuelingExceptions(ResourceMessage.InvalidOperationException, ex);
            }

            return clientesEntityAdded;
        }

        public List<ClientsEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public ClientsEntity GetById(int id)
        {
            return MapperInfrastructureClients.ClientDataModelToClientEntity(db.Clients.Find(id));
        }

        public ClientsEntity GetByName(string name)
        {
            throw new NotImplementedException();
        }
    }
}
