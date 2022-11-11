using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockAssessement3
{
    public class Town
    {
        public Town(List<Villager> villagers)
        {
            Villagers = villagers;
        }

        public List<Villager> Villagers { get; set; }

        //public void AddVillagers()
        //{
        //    var villager1 = new Villager;
        //    var villager2 = new Villager;
        //    var villager3 = new Villager;
        //    var villager4 = new Villager;
        //    villager4.Name=""
        //}

    }


}
