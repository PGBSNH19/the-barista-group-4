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
    }

    public interface IMakeBeverage
    {
        IMakeBeverage AddBeans(Beans beans);
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
    public string BeanType { get; set; }
    public bool IsGrounded { get; set; }
    public int Water { get; set; }
    public int SteamedMilk { get; set; }
    public int MilkFoam { get; set; }
    public int ChocolateSyrup { get; set; }
    public int WhippedCream { get; set; }
    
    class Program
    {
        static void Main(string[] args)
        {
            

        }
    }
}
