using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Group4
{
    public enum Coffee
    {
        Americano,
        Espresso,
        Cappuccino,
        Latte,
        Mocha,
        Macchiato
    }

    public enum Beans
    {
        Arabica,
        Robusta,
        Liberia
    }

    interface IName
    {
        IMakeBeverage CoffeeName(Coffee coffee);
        IMakeBeverage CoffeeName(string coffee);
    }

    interface IMakeBeverage
    {
        IMakeBeverage AddBeans(Beans beans);
        IMakeBeverage AddBeans(string beans);
        IMakeBeverage GrindBeans(bool grounded);
        IMakeBeverage AddWater(FluentCoffee ml);
        IMakeBeverage Validate(Func<FluentCoffee, bool> waterQuery);

        IMakeBeverage AddSteamedMilk(int ml);
        IMakeBeverage AddMilkFoam(int ml);
        IMakeBeverage AddChocolateSyrup(int ml);
        IMakeBeverage AddWhippedCream(int ml);
        string Serve();
    }

    class FluentCoffee : IMakeBeverage, IName
    {
        public string Name { get; set; }
        public string Bean { get; set; }
        public bool IsGrounded { get; set; }
        public FluentCoffee Water { get; set; }
        public int CoffeeTemp { get; set; }
        public int Temperature { get; set; }
        public int Amount { get; set; }
        public int SteamedMilk { get; set; }
        public int MilkFoam { get; set; }
        public int ChocolateSyrup { get; set; }
        public int WhippedCream { get; set; }

        public IMakeBeverage CoffeeName(Coffee coffee)
        {
            Name = coffee.ToString();
            return this;
        }

        public IMakeBeverage CoffeeName(string coffee)
        {
            Name = coffee;
            return this;
        }

        public IMakeBeverage AddBeans(Beans beans)
        {
            Bean = beans.ToString();
            return this;
        }

        public IMakeBeverage AddBeans(string beans)
        {
            Bean = beans;
            return this;
        }
        public IMakeBeverage GrindBeans(bool grounded)
        {
            IsGrounded = grounded;
            return this;
        }
        public IMakeBeverage AddWater(FluentCoffee ml)
        {
            Water = ml;
            return this;
        }

        public IMakeBeverage Validate(Func<FluentCoffee, bool> waterTemp)
        {
            if (waterTemp.Invoke(Water))
            {
                HeatWater(Water);
            }
            return this;
        }

        private void HeatWater(FluentCoffee water)
        {
            for (int i = water.Temperature; i < water.CoffeeTemp; i++)
            {
                Thread.Sleep(300);
                water.Temperature++;
                Console.WriteLine($"Current Temperature {i}");
            }
            Console.WriteLine("Coffee is Ready");
        }
        public IMakeBeverage AddSteamedMilk(int ml)
        {
            SteamedMilk = ml;
            return this;
        }
        public IMakeBeverage AddMilkFoam(int ml)
        {
            MilkFoam = ml;
            return this;
        }
        public IMakeBeverage AddChocolateSyrup(int ml)
        {
            ChocolateSyrup = ml;
            return this;
        }
        public IMakeBeverage AddWhippedCream(int ml)
        {
            WhippedCream = ml;
            return this;
        }

        public string Serve()
        {
            return this.Bean;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var espresso = new FluentCoffee()
                .CoffeeName(Coffee.Espresso)
                .AddBeans(Beans.Liberia)
                .GrindBeans(true)
                .AddWater(new FluentCoffee { Amount = 30, Temperature = 85, CoffeeTemp=90})
                .Validate(x => x.Temperature < x.CoffeeTemp)
                .Serve();
            Console.WriteLine(espresso);

            var espresso2 = new FluentCoffee()
                .CoffeeName("Espresso")
                .AddBeans("Liberia")
                .GrindBeans(true)
                .AddWater(new FluentCoffee { Amount=30, Temperature=88, CoffeeTemp=100})
                .Validate(x => x.Temperature < x.CoffeeTemp)
                .Serve();
            Console.WriteLine(espresso);

            var mocha = new FluentCoffee()
                .CoffeeName(Coffee.Mocha)
                .AddBeans(Beans.Robusta)
                .GrindBeans(true)
                .AddWater(new FluentCoffee { Amount=30, Temperature=87, CoffeeTemp = 90 })
                .Validate(x => x.Temperature < x.CoffeeTemp)
                .AddChocolateSyrup(20)
                .AddSteamedMilk(25)
                .AddWhippedCream(20)
                .Serve();
            Console.WriteLine(mocha);

            var americano = new FluentCoffee()
                .CoffeeName(Coffee.Americano)
                .AddBeans(Beans.Arabica)
                .GrindBeans(true)
                .AddWater(new FluentCoffee { Amount=30, Temperature=90, CoffeeTemp = 95 })
                .Validate(x => x.Temperature < x.CoffeeTemp)
                .Serve();
            Console.WriteLine(americano);

            Console.ReadKey();
        }
    }
}
