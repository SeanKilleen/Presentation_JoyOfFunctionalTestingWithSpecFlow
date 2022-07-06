using NUnit.Framework;
using ProductionCode;
using TechTalk.SpecFlow;

namespace OtherDemos
{
    [Binding]
    public class VendingMachineProductSteps
    {
        private VendingMachine _vendingMachine;
        private Product _product;

        [Given(@"I am at the vending machine")]
        public void GivenIAmAtTheVendingMachine()
        {
            _vendingMachine = new VendingMachine();
        }

        [When(@"I insert a quarter")]
        public void WhenIInsertAQuarter()
        {
            _vendingMachine.Add(25);
        }

        [When(@"I purchase a product")]
        public void WhenIPurchaseAProduct()
        {
            _product = _vendingMachine.PurchaseProduct();
        }

        [Then(@"I should receive the product")]
        public void ThenIShouldReceiveTheProduct()
        {
            Assert.That(_product, Is.Not.Null);
        }

        [Then(@"I should not receive the product")]
        public void ThenIShouldNotReceiveTheProduct()
        {
            Assert.That(_product, Is.Null);
        }

    }
}
