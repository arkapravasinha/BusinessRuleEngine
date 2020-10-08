using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRuleEngine.ClassLibrary
{
    public class BookPaymentUtility : IBookPaymentUtility
    {
        public void GenerateCommisionPaymentToAgent()
        {
            Console.WriteLine("Generating commision payment to the agent for book");
        }

        public void GeneratePackagingSlip()
        {
            Console.WriteLine("Creating a duplicate packaging slip for royalty department for book");
        }
    }
}
