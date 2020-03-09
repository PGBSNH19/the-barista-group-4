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

            var result = espresso.CoffeeName(Coffee.Espresso)
                .AddBeans(Beans.Liberia)
                .GrindBeans(true)
                .AddWater(new FluentCoffee { Amount=30, Temperature=80, CoffeeTemp=90})
                .Validate(x=>x.Temperature < 90)
                .Serve();
           

            Assert.IsInstanceOfType(result, typeof(string));
        }
    }
}
