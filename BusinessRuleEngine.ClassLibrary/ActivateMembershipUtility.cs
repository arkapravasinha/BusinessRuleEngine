using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRuleEngine.ClassLibrary
{
    public class ActivateMembershipUtility : IActivateMembershipUtility
    {
        public void ActivateMembership()
        {
            Console.WriteLine("Activated new membership");
        }

        public void SendMessageToUser()
        {
            Console.WriteLine("Membership is activated message sent to user");
        }
    }
}
