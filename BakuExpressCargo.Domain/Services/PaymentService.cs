using BakuExpressCargo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakuExpressCargo.Domain.Services
{
    public  class PaymentService
    {
        public bool ProcessPayment(Payment payment)
        {
            if (payment.Amount <= 0) throw new ArgumentException("Payment Amount must be greater than zero");

            payment.Status = PaymentStatus.Paid;
            payment.PaidAt = DateTime.UtcNow;
            return true;
            
        }

    }
}
