using System;
using System.Collections.Generic;
using System.Text;

namespace Mpc.MyAssociation.Domain.Models
{
    public class QuotaModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Value { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }
    }
}
