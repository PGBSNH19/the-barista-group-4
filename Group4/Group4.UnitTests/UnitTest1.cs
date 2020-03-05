using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Group4.UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestType()
        {
            var espresso = new FluentCoffee();

            var result = espresso.CoffeeName(Coffee.Espresso).AddBeans(Beans.Liberia).GrindBeans(true).AddWater(30).Serve();

            Assert.IsInstanceOfType(result, typeof(string));
        }
    }
}
