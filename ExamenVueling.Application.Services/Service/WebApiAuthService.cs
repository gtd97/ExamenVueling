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
    public class WebApiAuthService : IAuthenticationService<UserDto>
    {
        private readonly IRepositoryAuthentication<UserEntity> iRepositoryUser;

        public WebApiAuthService() : this(new AuthenticationRepository())
        {
        }

        public WebApiAuthService(AuthenticationRepository authenticationRepository)
        {
            this.iRepositoryUser = authenticationRepository;
        }

        public UserDto Authentication(string nombre, string email)
        {
            UserEntity userEntity = new UserEntity();
            userEntity = iRepositoryUser.Authentication(nombre, email);

            return MapperInfrastructureAuthentification.UserEntityToUserDto(userEntity);
        }
    }
}
