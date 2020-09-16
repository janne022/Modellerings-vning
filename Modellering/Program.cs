using System;

namespace Modellering
{
    class Program
    {
        static void Main(string[] args)
        {
            //intitiates 2 "kits" in an array, this could also be replaced with a list to add custom kits by the user
            Game[] gameKits = {new Game {gun = "Revolver", character = "Speed Warrior", healthKits = 2}, new Game {gun = "Sniper", character = "American Sniper", healthKits = 0}};
            //lists all kits (the character in all kits)
            System.Console.WriteLine("Choose a kit: ");
            for (int i = 0; i < gameKits.Length; i++)
            {
                System.Console.WriteLine("\n" + gameKits[i].character);
            }
            //parsing input
            string chosenKit = Console.ReadLine();
            bool success = int.TryParse(chosenKit, out int chosenKitInt);
            chosenKitInt -= 1;
            System.Console.WriteLine("You chose: " + gameKits[chosenKitInt].character);
            System.Console.WriteLine("Press Enter to continue");
            Console.ReadLine();
            Console.Clear();
            //list traits of class, possible to make more effective with GetType method
            System.Console.WriteLine($"Class information: \nClass name: {gameKits[chosenKitInt].character}\nGun: {gameKits[chosenKitInt].gun}\nAmount of healthpacks: {gameKits[chosenKitInt].healthKits}");
            Console.ReadLine();
        }
    }
}
