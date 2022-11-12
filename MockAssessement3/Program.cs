// See https://aka.ms/new-console-template for more information

using MockAssessement3;

try
{
    Console.WriteLine("Starting");
    // Instantiat the town with the Villagers already created
    Town myTown = new Town();
    Console.WriteLine("Done");
    Console.ReadLine();
}
catch (Exception ex)
{

    Console.WriteLine($"Error here: {ex.ToString()}");
}
