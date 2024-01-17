using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPatter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Payment order = new CardPayment();
            order._IPaymentSystem = new CityBankPaymentSystem();
            order.MakePayment();

            order._IPaymentSystem = new IDbiPaymentSystem();
            order.MakePayment();

            order = new NetBankingPayment();
            order._IPaymentSystem = new CityBankPaymentSystem();
            order.MakePayment();

            order._IPaymentSystem = new IDbiPaymentSystem();
            order.MakePayment();    

            Console.ReadLine();

        }
    }
}
