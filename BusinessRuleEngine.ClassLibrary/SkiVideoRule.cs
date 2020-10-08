using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRuleEngine.ClassLibrary
{
    public class SkiVideoRule : IBusinessRule
    {
        ISkiVideoPaymentUtility skiVideoPaymentUtility = null;
        public SkiVideoRule(ISkiVideoPaymentUtility skiVideoPaymentUtility)
        {
            this.skiVideoPaymentUtility = skiVideoPaymentUtility;
        }
        public void ProcessPayment()
        {
            skiVideoPaymentUtility.GeneratePackagingSlip();
        }
    }
}
