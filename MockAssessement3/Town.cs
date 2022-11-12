using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockAssessement3
{
    public class Town
    {
        public List<Villager> Villagers = new List<Villager>();
        public int VillageHarvest { get; set; }
        public int TotalFoodConsumption {get;set;}
        public List<int> LTtlFoodConsumed = new List<int>();
        public bool SurviveWinter;

        public Town()
        {
          AddVillagers();
          Console.WriteLine("Break");
        }

        public int CalcFoodConsumption()
        {
        
            return LTtlFoodConsumed.Sum();
        }

        public void AddVillagers()
        {
            // Instantiate farmer and add to the list of Villagers
            Farmer farmer1 = new Farmer();
            // add food consumed to list
            LTtlFoodConsumed.Add(farmer1.Hunger);
            Villagers.Add(farmer1);
            //Instatiate 3 slackers and add to the list of Villagers
            Slacker slacker1 = new Slacker();
            LTtlFoodConsumed.Add(slacker1.Hunger);
            Villagers.Add(slacker1);
            Slacker slacker2 = new Slacker();
            Villagers.Add(slacker2);
            // add food consumed to list
            LTtlFoodConsumed.Add(slacker2.Hunger);
            Slacker slacker3 = new Slacker();
            // add food consumed to list
            LTtlFoodConsumed.Add(slacker3.Hunger);
            Villagers.Add(slacker3);
            SurviveWinter = SurviveTheWinter();
            Console.WriteLine("Break here");

        }
        // Renamed to "Harvest" for homework. 
        public int Harvest(List<Villager> listOfVillagers)
        { 
            int harvest = 0;
            foreach (var v in listOfVillagers)
            {
                Console.WriteLine(v);
                var amountFarmed = v.Farm();
                harvest = harvest + amountFarmed;
                Console.WriteLine(v);
            }
            return harvest;        
        }


        public bool SurviveTheWinter()
        {
            bool survive;
            // HW requirement Call and Store the result of the Harvest Method
            VillageHarvest = Harvest(Villagers);
            Console.WriteLine("Exepecting 2 for Harvest");

            // HW requirement Call and Store the result of the CalcFoodConsumption
             TotalFoodConsumption = CalcFoodConsumption();
            if (TotalFoodConsumption <= VillageHarvest)
            {
                survive = true;
            }
            else
            {
                survive = false;
            }
            return survive;
        }



    }


}
