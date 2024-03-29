﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenVueling.Application.Dto
{
    public class PoliciesDto
    {
        public string id { get; set; }
        public double amountInsured { get; set; }
        public string email { get; set; }
        public System.DateTime inceptionDate { get; set; }
        public bool installmentPayment { get; set; }
        public string clientId { get; set; }

        public PoliciesDto() { }

        public PoliciesDto(string id, double amountInsured, string email, DateTime inceptionDate, bool installmentPayment, string clientId)
        {
            this.id = id;
            this.amountInsured = amountInsured;
            this.email = email;
            this.inceptionDate = inceptionDate;
            this.installmentPayment = installmentPayment;
            this.clientId = clientId;
        }

    }
}
