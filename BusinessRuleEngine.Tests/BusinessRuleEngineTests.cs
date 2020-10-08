using System;
using System.IO;
using BusinessRuleEngine.ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BusinessRuleEngine.Tests
{
    [TestClass]
    public class BusinessRuleEngineTests
    {
        [TestMethod]
        public void PhysicalProductBusinessRuleEngine_Test()
        {
            Payment physicalProductPayment = new Payment()
            {
                PaymentAmount = 10,
                ProductType = ProductType.PhysicalProduct
            };
            BusinessRuleExecutor businessRuleExecutor = new BusinessRuleExecutor(physicalProductPayment.ProductType);

            
            using (StringWriter stringWriter=new StringWriter())
            {
                Console.SetOut(stringWriter);

                businessRuleExecutor.ApplyBusinessRule();

                string expected = string.Format("Generating commision payment to the agent for physical product{0}Generating packaging slip for shipment for physical product{0}", Environment.NewLine);

                Assert.AreEqual(expected, stringWriter.ToString());
            }
            
        }

        [TestMethod]
        public void BookBusinessRuleEngine_Test()
        {
            Payment physicalProductPayment = new Payment()
            {
                PaymentAmount = 10,
                ProductType = ProductType.Book
            };
            BusinessRuleExecutor businessRuleExecutor = new BusinessRuleExecutor(physicalProductPayment.ProductType);


            using (StringWriter stringWriter = new StringWriter())
            {
                Console.SetOut(stringWriter);

                businessRuleExecutor.ApplyBusinessRule();

                string expected = string.Format("Generating commision payment to the agent for book{0}Creating a duplicate packaging slip for royalty department for book{0}", Environment.NewLine);

                Assert.AreEqual(expected, stringWriter.ToString());
            }

        }

        [TestMethod]
        public void ActivateMembershipBusinessRuleEngine_Test()
        {
            Payment physicalProductPayment = new Payment()
            {
                PaymentAmount = 10,
                ProductType = ProductType.Membership
            };
            BusinessRuleExecutor businessRuleExecutor = new BusinessRuleExecutor(physicalProductPayment.ProductType);


            using (StringWriter stringWriter = new StringWriter())
            {
                Console.SetOut(stringWriter);

                businessRuleExecutor.ApplyBusinessRule();

                string expected = string.Format("Activated new membership{0}Membership is activated message sent to user{0}", Environment.NewLine);

                Assert.AreEqual(expected, stringWriter.ToString());
            }

        }

        [TestMethod]
        public void UpgradeMembershipBusinessRuleEngine_Test()
        {
            Payment physicalProductPayment = new Payment()
            {
                PaymentAmount = 10,
                ProductType = ProductType.UpgradeMembership
            };
            BusinessRuleExecutor businessRuleExecutor = new BusinessRuleExecutor(physicalProductPayment.ProductType);


            using (StringWriter stringWriter = new StringWriter())
            {
                Console.SetOut(stringWriter);

                businessRuleExecutor.ApplyBusinessRule();

                string expected = string.Format("Membership Upgraded{0}Membership upgraded message sent to the User{0}", Environment.NewLine);

                Assert.AreEqual(expected, stringWriter.ToString());
            }

        }

        [TestMethod]
        public void SkiVideoBusinessRuleEngine_Test()
        {
            Payment physicalProductPayment = new Payment()
            {
                PaymentAmount = 10,
                ProductType = ProductType.SkiVideo
            };
            BusinessRuleExecutor businessRuleExecutor = new BusinessRuleExecutor(physicalProductPayment.ProductType);


            using (StringWriter stringWriter = new StringWriter())
            {
                Console.SetOut(stringWriter);

                businessRuleExecutor.ApplyBusinessRule();

                string expected = string.Format("Added Free \"First Aid\" video to the packaging slip as per norms{0}", Environment.NewLine);

                Assert.AreEqual(expected, stringWriter.ToString());
            }

        }
    }
}
