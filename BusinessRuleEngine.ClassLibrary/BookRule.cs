using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRuleEngine.ClassLibrary
{
    public class BookRule : IBusinessRule
    {
        IBookPaymentUtility bookPaymentUtility = null;
        public BookRule(IBookPaymentUtility bookPaymentUtility)
        {
            this.bookPaymentUtility = bookPaymentUtility;
        }
        public void ProcessPayment()
        {
            bookPaymentUtility.GenerateCommisionPaymentToAgent();
            bookPaymentUtility.GeneratePackagingSlip();
        }
    }
}
