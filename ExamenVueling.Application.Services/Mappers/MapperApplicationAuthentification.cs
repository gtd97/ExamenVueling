using ExamenVueling.Application.Dto;
using ExamenVueling.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenVueling.Application.Services.Mappers
{
    public class MapperApplicationAuthentification
    {
        public static UserDto ClientDtoToClientEntity(UserEntity userEntity)
        {
            UserDto clientEntity = new UserDto(userEntity.nombre, userEntity.email, userEntity.role);
            return clientEntity;
        }
    }
}
