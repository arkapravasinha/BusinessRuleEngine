using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRuleEngine.ClassLibrary
{
    public class PhysicalProductRule : IBusinessRule
    {
        IPhysicalProductPaymentUtility physicalProductPaymentUtility = null;

        public PhysicalProductRule(IPhysicalProductPaymentUtility physicalProductPaymentUtility)
        {
            this.physicalProductPaymentUtility = physicalProductPaymentUtility;
        }

        public void ProcessPayment()
        {
            physicalProductPaymentUtility.GenerateCommisionPaymentToAgent();
            physicalProductPaymentUtility.GeneratePackagingSlip();
        }
    }
}
