using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRuleEngine.ClassLibrary
{
    public class SkiVideoPaymentUtility : ISkiVideoPaymentUtility
    {
        public void GeneratePackagingSlip()
        {
            Console.WriteLine("Added Free \"First Aid\" video to the packaging slip as per norms");
        }
    }
}
