using ExamenVueling.Domain.Models;
using ExamenVueling.Infrastructure.Repository.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenVueling.Infrastructure.Repository.Mappers
{
    public class MapperInfrastructureClients
    {
        /// <summary>
        /// Clients the data model to client entity.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <returns></returns>
        public static ClientsEntity ClientDataModelToClientEntity(Clients model)
        {
            ClientsEntity clientEntity = new ClientsEntity(model.id, model.nombre, model.email, model.role);

            return clientEntity;
        }

        /// <summary>
        /// Clients the data model to client entity.
        /// </summary>
        /// <param name="listaClientsDataModel">The lista clients data model.</param>
        /// <returns></returns>
        public static List<ClientsEntity> ClientDataModelToClientEntity(List<Clients> listaClientsDataModel)
        {
            List<ClientsEntity> listaClientsEntity = new List<ClientsEntity>();

            foreach (var client in listaClientsDataModel)
            {
                listaClientsEntity.Add(ClientDataModelToClientEntity(client));
            }

            return listaClientsEntity;
        }

    }
}
