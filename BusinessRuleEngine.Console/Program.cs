
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessRuleEngine.ClassLibrary;

namespace BusinessRuleEngine.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Payment> payments = new List<Payment>()
            {
                new Payment(){PaymentAmount=10,ProductType=ProductType.PhysicalProduct },
                new Payment(){PaymentAmount=11,ProductType=ProductType.Book },
                new Payment(){PaymentAmount=12,ProductType=ProductType.Membership },
                new Payment(){PaymentAmount=13,ProductType=ProductType.UpgradeMembership },
                new Payment(){PaymentAmount=14,ProductType=ProductType.SkiVideo },
                new Payment(){PaymentAmount=15,ProductType=ProductType.PhysicalProduct },
            };
            foreach (var payment in payments)
            {
                BusinessRuleExecutor businessRuleExecutor = new BusinessRuleExecutor(payment.ProductType);
                businessRuleExecutor.ApplyBusinessRule();
            }
            System.Console.WriteLine("Press enter to exit the program");
            System.Console.ReadLine();
        }
    }
}
