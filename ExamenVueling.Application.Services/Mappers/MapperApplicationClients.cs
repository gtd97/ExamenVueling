using ExamenVueling.Application.Dto;
using ExamenVueling.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenVueling.Application.Services.Mappers
{
    public class MapperApplicationClients
    {
        /// <summary>
        /// Clients the dto to client entity.
        /// </summary>
        /// <param name="clientDto">The client dto.</param>
        /// <returns></returns>
        public static ClientsEntity ClientDtoToClientEntity(ClientsDto clientDto)
        {
            ClientsEntity clientEntity = new ClientsEntity(clientDto.id, clientDto.nombre, clientDto.email, clientDto.role);
            return clientEntity;
        }


        /// <summary>
        /// Clients the dto to client entity.
        /// </summary>
        /// <param name="listaClientsDto">The lista clients dto.</param>
        /// <returns></returns>
        public static List<ClientsEntity> ClientDtoToClientEntity(List<ClientsDto> listaClientsDto)
        {
            List<ClientsEntity> listaClientsEntity = new List<ClientsEntity>();

            foreach (var client in listaClientsDto)
            {
                listaClientsEntity.Add(ClientDtoToClientEntity(client));
            }

            return listaClientsEntity;
        }
    }
}
