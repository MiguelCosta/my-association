using System;

namespace Mpc.MyAssociation.Application.Dto
{
    public class QuotaDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Value { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

    }
}
