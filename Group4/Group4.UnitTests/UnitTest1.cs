using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Group4.UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var espresso = new FluentCoffee().CoffeeName(Coffee.Espresso).AddBeans(Beans.Liberia).GrindBeans(true).AddWater(30).Serve();

        }
    }
}
