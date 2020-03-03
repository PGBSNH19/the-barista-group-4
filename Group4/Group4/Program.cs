using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please choose type of coffe!");
            Console.WriteLine("1 Espresso");
            Console.WriteLine("2 Latte");
            Console.WriteLine("3 Black coffe");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:                   
                        break;
                case 2:
                    break;

                case 3:
                    break;
            }


            var name = new CoffeeMachine().WaterVolume()
                .AddBeans();


        }
    }
}
