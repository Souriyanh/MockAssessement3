﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockAssessement3
{
    public class Town
    {
        public List<Villager> Villagers = new List<Villager>();
        public int Harvest { get; set; }

        public Town()
        {
          AddVillagers();
        }
        public void AddVillagers()
        {
            // Instantiate farmer and add to the list of Villagers
            Farmer farmer1 = new Farmer();
            Villagers.Add(farmer1);
            //Instatiate 3 slackers and add to the list of Villagers
            Slacker slacker1 = new Slacker();
            Villagers.Add(slacker1);
            Slacker slacker2 = new Slacker();
            Villagers.Add(slacker2);
            Slacker slacker3 = new Slacker();
            Villagers.Add(slacker3);
            Harvest = CalcHarvest(Villagers);
            Console.WriteLine("Exepecting 2 for Harvest");

        }

        public int CalcHarvest(List<Villager> listOfVillagers)
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

        //public int CalcFoodConsumption()
        //{ 

        //}
        //public bool SurviveTheWinter()
        //{ 

        //}



    }


}
