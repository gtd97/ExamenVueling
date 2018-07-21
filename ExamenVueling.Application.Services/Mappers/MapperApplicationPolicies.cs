using ExamenVueling.Application.Dto;
using ExamenVueling.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenVueling.Application.Services.Mappers
{
    public class MapperApplicationPolicies
    {
        public static PoliciesEntity PoliciesDtoToPoliciesEntity(PoliciesDto policiesDto)
        {
            PoliciesEntity policiesEntity = new PoliciesEntity(policiesDto.id, policiesDto.amountInsured, policiesDto.email, policiesDto.inceptionDate, policiesDto.installmentPayment, policiesDto.clientId);
            return policiesEntity;
        }


        public static List<PoliciesEntity> PoliciesDtoToPoliciesEntity(List<PoliciesDto> listaPoliciesDto)
        {
            List<PoliciesEntity> listaPoliciesEntity = new List<PoliciesEntity>();

            foreach (var policies in listaPoliciesDto)
            {
                listaPoliciesEntity.Add(PoliciesDtoToPoliciesEntity(policies));
            }

            return listaPoliciesEntity;
        }
    }
}
