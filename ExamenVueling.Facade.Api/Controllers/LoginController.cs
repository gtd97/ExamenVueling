using ExamenVueling.Application.Dto;
using ExamenVueling.Application.Services.Contracts;
using ExamenVueling.Application.Services.Service;
using ExamenVueling.Facade.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading;
using System.Web;
using System.Web.Http;

namespace ExamenVueling.Facade.Api.Controllers
{
    [AllowAnonymous]
    public class LoginController : ApiController
    {
        private readonly IAuthenticationService<UserDto> authenticationService;

        public LoginController() : this(new WebApiAuthentication())
        {
        }

        public LoginController(WebApiAuthentication authenticationService)
        {
            this.authenticationService = authenticationService;
        }


        [HttpPost]
        [Route("api/authenticate")]
        public IHttpActionResult Authenticate(ModelAuthentication login)
        {
            if (login == null)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            //TODO: Validate credentials Correctly, this code is only for demo !!

            UserDto user = authenticationService.Authentication(login.name, login.email);

            bool isCredentialValid = (user != null && login.name == user.nombre && login.email == user.email);
            
            if (isCredentialValid)
            {
                var token = TokenGenerator.GenerateTokenJwt(user.nombre, user.email, user.role);
                return Ok(token);
            }
            else
            {
                return Unauthorized();
            }
        }
    }
}