using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRuleEngine.ClassLibrary
{
    public class UpgradeMembershipRule : IBusinessRule
    {
        IUpgradeMembershipUtility upgradeMembershipUtility = null;
        public UpgradeMembershipRule(IUpgradeMembershipUtility upgradeMembershipUtility)
        {
            this.upgradeMembershipUtility = upgradeMembershipUtility;
        }
        public void ProcessPayment()
        {
            upgradeMembershipUtility.UpgradeMembership();
            upgradeMembershipUtility.SendMessageToUser();
        }
    }
}
