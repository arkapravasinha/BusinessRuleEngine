using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRuleEngine.ClassLibrary
{
    class PhysicalProductPaymentUtility : IPhysicalProductPaymentUtility
    {
        public void GenerateCommisionPaymentToAgent()
        {
            Console.WriteLine("Generating commision payment to the agent for physical product");
        }
        public void GeneratePackagingSlip()
        {
            Console.WriteLine("Generating packaging slip for shipment for physical product");
        }
    }
}
