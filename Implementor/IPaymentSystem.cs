using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPatter
{
    public interface IPaymentSystem
    {
        void ProcessPayment(string paymentSystem);
    }
}
