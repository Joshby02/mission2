using System;

namespace DiceRollingSimulator
{
    // This is the main class that handles user interaction and displaying results
    class Program
    {
        static void Main(string[] args)
        {
            // Display welcome message
            Console.WriteLine("Welcome to the dice throwing simulator!");

            // Get the number of rolls from the user
            Console.WriteLine("How many dice rolls would you like to simulate?");
            int numberOfRolls = int.Parse(Console.ReadLine());

            // Create an instance of the DiceRoller class
            // This is the "second class" mentioned in the assignment
            DiceRoller roller = new DiceRoller();

            // Call the method in DiceRoller to simulate the rolls
            // This returns an array with counts for each sum (index 2-12)
            int[] results = roller.RollDice(numberOfRolls);

            // Display the results header
            Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS");
            Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
            Console.WriteLine($"Total number of rolls = {numberOfRolls}.\n");

            // Loop through each possible dice sum (2 through 12)
            for (int sum = 2; sum <= 12; sum++)
            {
                // Calculate the percentage for this sum
                // We need to cast to double to get decimal division
                double percentage = (double)results[sum] / numberOfRolls * 100;

                // Round to nearest integer for number of asterisks
                int asteriskCount = (int)Math.Round(percentage);

                // Create a string of asterisks
                string asterisks = new string('*', asteriskCount);

                // Display the sum and its histogram bar
                Console.WriteLine($"{sum}: {asterisks}");
            }

            // Display goodbye message
            Console.WriteLine("\nThank you for using the dice throwing simulator. Goodbye!");
        }
    }
}