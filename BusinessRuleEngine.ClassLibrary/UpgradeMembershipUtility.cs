using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRuleEngine.ClassLibrary
{
    class UpgradeMembershipUtility : IUpgradeMembershipUtility
    {
        public void UpgradeMembership()
        {
            Console.WriteLine("Membership Upgraded");
        }

        public void SendMessageToUser()
        {
            Console.WriteLine("Membership upgraded message sent to the User");
        }
    }
}
