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
    public class ClientsService : IService<ClientsDto>
    {
        private readonly IRepository<ClientsEntity> iRepository;

        public ClientsService() : this(new ClientsRepository())
        {
        }

        public ClientsService(ClientsRepository clientsRepository)
        {
            this.iRepository = clientsRepository;
        }




        public ClientsDto Add(ClientsDto model)
        {
            ClientsDto client = new ClientsDto();
            //ClientsDto client = iRepository.Add(model)
            //ClientsDto client = iRepository.Add(MapperApplicationClients.ClientDtoToClientEntity(model));

            return client;
        }

        

        public List<ClientsDto> GetAll()
        {
            throw new NotImplementedException();
        }

        public ClientsDto GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public ClientsDto GetById(string name)
        {
            throw new NotImplementedException();
        }

        public ClientsDto GetById(int id)
        {
            throw new NotImplementedException();
        }

        public ClientsDto Update(ClientsDto model)
        {
            throw new NotImplementedException();
        }

    }
}
