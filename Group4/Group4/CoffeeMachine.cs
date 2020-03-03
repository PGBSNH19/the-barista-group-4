using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group4
{

    /*Spionera: Properties: Waterlevel, beansvolume, cupQuantity*/
    class CoffeeMachine : IIngredients
    {
        enum BeanType
        {
            Robusta = 0,
            Arabica = 1

        }
        public void AddBeans(double amount, string sort)
        {
            Bean bean = new Bean();
            bean.AmountInG = amount;
            bean.Sort = sort;
        }
        public void WaterVolume(int volume) 
        {
            Water water = new Water();
            water.volume = volume;
        }

        
        public void HeatWater()
        {
            
        }
       
        public void Grinding(){ }
        public void LoadFilter() { }
        public void BeanpowderFilter() { }
        public void PourWater() { } //watervolume
        
     
        public void UnlodFilter(){ }
        
        public void CheckForCup() {}


  
    }

  
}
