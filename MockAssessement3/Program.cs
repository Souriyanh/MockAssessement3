// See https://aka.ms/new-console-template for more information

using MockAssessement3;

try
{
    Console.WriteLine("Starting");
    // Instantiate the town with the Villagers already created
    Town myTown = new Town();

    // Display the list of food consumed to the console
    Console.WriteLine($"Total Food Consumed by the village: {myTown.TotalFoodConsumption}");
    // Display to the console if the village will survive the winter
    Console.WriteLine($"Will the village survive the winter? {myTown.SurviveTheWinter}");
    Console.WriteLine("Done");
    Console.ReadLine();
}
catch (Exception ex)
{

    Console.WriteLine($"Error here: {ex.ToString()}");
}
