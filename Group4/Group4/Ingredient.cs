using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group4
{
    interface IIngredients
    {
        IIngredients WaterVolume();
        IIngredients AddBeans(double amount, string sort);
    }
    class Ingredient
    {

    }
    
    
    class Coffee
    {

        int a = (int) BeanType.Arabica;

        enum CoffeeType
        {
            Dark = 0,
            Cappuchino = 1,
            Latte = 2
        }

        //public void ChooseCoffee(CoffeeType coffee, BeanType bean)
        //{

        //}
    }
    
   // var goodCoffee = new Coffee().
}
