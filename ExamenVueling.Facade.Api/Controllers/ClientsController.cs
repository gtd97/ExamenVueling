using ExamenVueling.Application.Dto;
using ExamenVueling.Application.Services.Contracts;
using ExamenVueling.Application.Services.Service;
using ExamenVueling.Common.Layer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ExamenVueling.Facade.Api.Controllers
{
    public class ClientsController : ApiController
    {
        private readonly IService<ClientsDto> clientsService;

        // Con el this en el constructor, estamos creando un instancia, pero no haria un acomplamiento "falsa inyeccion de dependencias"
        public ClientsController() : this(new ClientsService())
        {
        }

        public ClientsController(ClientsService clientsService)
        {
            this.clientsService = clientsService;
        }


        // GET: api/Clients
        public IHttpActionResult Get()
        {
            try
            {
                List<ClientsDto> listaClients = clientsService.GetAll();

                if (listaClients != null)
                {
                    return Ok(listaClients);
                }
                else
                {
                    return NotFound();
                }
            }
            catch (VuelingExceptions ex)
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }
        }

        // GET: api/Clients/5
        public IHttpActionResult Get(string id)
        {
            try
            {
                ClientsDto client = clientsService.GetById(id);

                if (client != null)
                {
                    return Ok(client);
                }
                else
                {
                    return NotFound();
                }
            }
            catch (VuelingExceptions ex)
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }
        }

        // POST: api/Clients
        public IHttpActionResult Post(ClientsDto value)
        {
            return Ok();
        }

        // PUT: api/Clients/5
        public IHttpActionResult Put(string id, ClientsDto value)
        {
            return Ok();
        }

        // DELETE: api/Clients/5
        public IHttpActionResult Delete(string id)
        {
            return Ok();
        }
    }
}
