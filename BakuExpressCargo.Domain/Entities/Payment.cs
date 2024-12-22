using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakuExpressCargo.Domain.Entities
{
    public  class Payment
    {
        public int Id { get; set; }

        public int PackageId { get; set; }

        public decimal Amount { get; set; }

        public PaymentStatus Status { get; set; }

        public DateTime PaidAt { get; set; }
    }


    public enum PaymentStatus
    {
        Pending,
        Paid,
        Failed,
        Canceled,
        Refunded
    }


   
}
