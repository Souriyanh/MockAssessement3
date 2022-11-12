using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace MockAssessement3
{
    public abstract class Villager
    {
       // protected int VillagerHunger;
        abstract public int Farm();
    }

    public class Farmer : Villager
    {
        private int Hunger = 0; // set the zero for now 
        private int farm = 2;
        
        //Constructor that sets hunger to 1
        public Farmer()
            {
            this.Hunger = 1;
            }

        public override int Farm()
        {
            return farm;
        }
    }

    public class Slacker : Villager
    {
        private int Hunger = 0; // set the zero for now 
        private int farm = 0;

        //Constructor that sets hunger to 1
        public Slacker()
        {
            this.Hunger = 3;
        }

        public override int Farm()
        {
            return farm;
        }
    }
}
