using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockAssessement3
{
    public abstract class Villager
    {
        public abstract string Name { get; set; }    
        public int Hunger { get; set; }

         abstract public int Farm();
      
    }

    public class Farmer : Villager
    {
         int Hunger = 1;
        public override int Farm()
        {
           return Hunger;
        }
    }

    public class Slacker : Villager
    {
        public int Hunger = 3;
        public override int Farm()
        {
            return Hunger;
        }
    }


}
