using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockAssessement3
{
    public abstract class Villager
    {
        protected int VillagerHunger;
        public abstract int Hunger{get;set;}
       // public abstract int Farm { get; set; }
    }

    public class Farmer : Villager
    {
        public override int Hunger
        {
            get
            {
                return VillagerHunger = 1;
            }
            set
            {
                VillagerHunger = value;
            }
        }
    }

    public class Slacker : Villager
    {
        public override int Hunger
        {
            get
            {
                return VillagerHunger = 3;
            }
            set
            {
                VillagerHunger = value;
            }
        }
    }


}
