﻿using ExamenVueling.Domain.Models;
using ExamenVueling.Infrastructure.Repository.Contracts;
using ExamenVueling.Infrastructure.Repository.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenVueling.Infrastructure.Repository.Repository
{
    public class PoliciesRepository : IRepository<PoliciesEntity>
    {
        ExamenVuelingEntities db = new ExamenVuelingEntities();

        public PoliciesEntity Add(PoliciesEntity model)
        {
            throw new NotImplementedException();
        }

        public List<PoliciesEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public PoliciesEntity GetById(int id)
        {
            throw new NotImplementedException();
        }

        public PoliciesEntity GetByName(string name)
        {
            throw new NotImplementedException();
        }
    }
}