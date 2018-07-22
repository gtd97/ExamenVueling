using ExamenVueling.Application.Dto;
using ExamenVueling.Application.Services.Contracts;
using ExamenVueling.Application.Services.Mappers;
using ExamenVueling.Domain.Models;
using ExamenVueling.Infrastructure.Repository.Contracts;
using ExamenVueling.Infrastructure.Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenVueling.Application.Services.Service
{
    public class WebApiService : IService<ClientsDto>
    {
        private readonly IRepository<ClientsEntity> iRepository;

        public WebApiService() : this(new ClientsRepository())
        {
        }

        public WebApiService(ClientsRepository clientsRepository)
        {
            this.iRepository = clientsRepository;
        }


        public List<ClientsDto> GetAll()
        {
            List<ClientsEntity> lista = iRepository.GetAll();
            return MapperApplicationClients.ClientEntityToClientDto(lista);
        }

        public ClientsDto GetById(string id)
        {
            ClientsEntity client = iRepository.GetById(id);
            return MapperApplicationClients.ClientEntityToClientDto(client);
        }

        public ClientsDto GetByName(string name)
        {
            ClientsEntity client = iRepository.GetByName(name);
            return MapperApplicationClients.ClientEntityToClientDto(client);
        }

    }
}
