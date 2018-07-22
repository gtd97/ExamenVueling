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
    
    public class WebApiController : ApiController
    {
        private readonly IService<ClientsDto> clientsService;

        // Con el this en el constructor, estamos creando un instancia, pero no haria un acomplamiento "falsa inyeccion de dependencias"
        public WebApiController() : this(new WebApiService())
        {
        }

        public WebApiController(WebApiService clientsService)
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

        // GET api/Clients/{id}
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


        // GET api/Clients/{name}
        [Route("api/Clients/{name}")]
        public IHttpActionResult GetByName(string name)
        {
            try
            {
                ClientsDto client = clientsService.GetByName(name);

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

    }
}
