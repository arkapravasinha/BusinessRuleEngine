using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRuleEngine.ClassLibrary
{
    public class MembershipRule : IBusinessRule
    {
        IActivateMembershipUtility activateMembershipUtility = null;
        public MembershipRule(IActivateMembershipUtility activateMembershipUtility)
        {
            this.activateMembershipUtility = activateMembershipUtility;
        }
        public void ProcessPayment()
        {
            activateMembershipUtility.ActivateMembership();
            activateMembershipUtility.SendMessageToUser();
        }
    }
}
