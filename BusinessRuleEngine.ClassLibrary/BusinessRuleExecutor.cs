using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRuleEngine.ClassLibrary
{
    public class BusinessRuleExecutor : IBusinessRuleExecutor
    {
        IBusinessRule businessRule = null;

        IPhysicalProductPaymentUtility physicalProductPaymentUtility = new PhysicalProductPaymentUtility();
        IBookPaymentUtility bookPaymentUtility = new BookPaymentUtility();
        IUpgradeMembershipUtility upgradeMembershipUtility = new UpgradeMembershipUtility();
        IActivateMembershipUtility activateMembershipUtility = new ActivateMembershipUtility();
        ISkiVideoPaymentUtility skiVideoPaymentUtility = new SkiVideoPaymentUtility();
        //Add new utilities as per requirement

        public BusinessRuleExecutor(ProductType productType)
        {
            switch (productType)
            {
                case ProductType.PhysicalProduct:
                    businessRule = new PhysicalProductRule(physicalProductPaymentUtility);
                    break;
                case ProductType.Book:
                    businessRule = new BookRule(bookPaymentUtility);
                    break;
                case ProductType.Membership:
                    businessRule = new MembershipRule(activateMembershipUtility);
                    break;
                case ProductType.UpgradeMembership:
                    businessRule = new UpgradeMembershipRule(upgradeMembershipUtility);
                    break;
                case ProductType.SkiVideo:
                    businessRule = new SkiVideoRule(skiVideoPaymentUtility);
                    break;
                default:
                    businessRule = null;
                    break;
            }
        }

        public void ApplyBusinessRule()
        {
            if (businessRule == null)
            {
                Console.WriteLine("No product type found in payment");
                return;
            }
            businessRule.ProcessPayment();
        }
    }
}
