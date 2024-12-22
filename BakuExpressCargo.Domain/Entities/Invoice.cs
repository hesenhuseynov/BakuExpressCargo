using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakuExpressCargo.Domain.Entities
{
    public  class Invoice
    {
        public int Id { get; set; }
        public int PaymentId { get; set; }
        public Payment Payment { get; set; }

        public DateTime InvoiceData { get; set; }

        public string InvoiceNumber { get; set; }
    }
}
