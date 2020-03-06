using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

    public interface IName
    {
        IMakeBeverage CoffeeName(Coffee coffee);
        IMakeBeverage CoffeeName(string coffee);
    }

    public interface IMakeBeverage
    {
        IMakeBeverage AddBeans(Beans beans);
        IMakeBeverage AddBeans(string beans);
        IMakeBeverage GrindBeans(bool grounded);
        IMakeBeverage AddWater(int ml);
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
        public int Water { get; set; }
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
        public IMakeBeverage AddWater(int ml)
        {
            Water += ml;
            return this;
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
            var espresso = new FluentCoffee().CoffeeName(Coffee.Espresso).AddBeans(Beans.Liberia).GrindBeans(true).AddWater(30).Serve();
            Console.WriteLine(espresso);

            var espresso2 = new FluentCoffee().CoffeeName("Espresso").AddBeans("Liberia").GrindBeans(true).AddWater(30).Serve();
            Console.WriteLine(espresso);

            var mocha = new FluentCoffee().CoffeeName(Coffee.Mocha).AddBeans(Beans.Robusta).GrindBeans(true).AddWater(30).AddChocolateSyrup(20).AddSteamedMilk(25).AddWhippedCream(20).Serve();
            Console.WriteLine(mocha);

            var americano = new FluentCoffee().CoffeeName(Coffee.Americano).AddBeans(Beans.Arabica).GrindBeans(true).AddWater(30).AddWater(60).Serve();
            Console.WriteLine(americano);

            Console.ReadKey();
        }
    }
}
