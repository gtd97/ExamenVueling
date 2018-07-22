using ExamenVueling.Application.Dto;
using ExamenVueling.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenVueling.Application.Services.Mappers
{
    public class MapperInfrastructureAuthentification
    {
        public static UserDto UserEntityToUserDto(UserEntity userEntity)
        {
            UserDto userDto = new UserDto(userEntity.nombre, userEntity.email, userEntity.role);
            return userDto;
        }
    }
}
