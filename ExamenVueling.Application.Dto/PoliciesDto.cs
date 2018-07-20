using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenVueling.Application.Dto
{
    public class PoliciesDto
    {
        public int Id { get; set; }
        public string AmountInsured { get; set; }
        public string Email { get; set; }
        public string InceptionDate { get; set; }
        public bool InstallmentPayment { get; set; }
        public int ClientId { get; set; }

        public PoliciesDto() { }

        public PoliciesDto(string amountInsured, string email, string inceptionDate, bool installmentPayment, int clientId)
        {
            this.AmountInsured = amountInsured;
            this.Email = email;
            this.InceptionDate = inceptionDate;
            this.InstallmentPayment = installmentPayment;
            this.ClientId = clientId;
        }

        public PoliciesDto(int id, string amountInsured, string email, string inceptionDate, bool installmentPayment, int clientId)
        {
            this.Id = id;
            this.AmountInsured = amountInsured;
            this.Email = email;
            this.InceptionDate = inceptionDate;
            this.InstallmentPayment = installmentPayment;
            this.ClientId = clientId;
        }
    }
}
