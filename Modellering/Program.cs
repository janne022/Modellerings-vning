using System;

namespace Modellering
{
    class Program
    {
        static void Main(string[] args)
        {
            Game kit1 = new Game() {gun = "Revolver", character = "Speed Warrior", healthKits = 2};
            Game kit2 = new Game() {gun = "Sniper", character = "American Sniper", healthKits = 0};
            

            Game[] gameKits = {kit1, kit2};
            System.Console.WriteLine("Choose a kit: ");
            for (int i = 0; i < gameKits.Length; i++)
            {
                System.Console.WriteLine("\n" + gameKits[i].character);
            }
            string chosenKit = Console.ReadLine();
            bool success = int.TryParse(chosenKit, out int chosenKitInt);
            chosenKitInt -= 1;
            System.Console.WriteLine("You chose: " + gameKits[chosenKitInt].character);
            System.Console.WriteLine("Press Enter to continue");
            Console.ReadLine();
            Console.Clear();
            System.Console.WriteLine($"Class information: \nClass name: {gameKits[chosenKitInt].character}\nGun: {gameKits[chosenKitInt].gun}\nAmount of healthpacks: {gameKits[chosenKitInt].healthKits}");
            Console.ReadLine();
        }
    }
}
