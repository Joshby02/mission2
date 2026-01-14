using System;

namespace DiceRollingSimulator
{
    // This is the second class that handles the actual dice rolling simulation
    class DiceRoller
    {
        // Random number generator - we create it once as a class member
        // This gives us better randomness than creating new Random() each time
        private Random random = new Random();

        // This method simulates rolling two dice multiple times
        // Parameter: numberOfRolls - how many times to roll the dice
        // Returns: an array containing the count of each sum (2-12)
        public int[] RollDice(int numberOfRolls)
        {
            // Create an array to store results
            // Index 0 and 1 won't be used since minimum sum is 2
            // Indices 2-12 will store counts for those sums
            int[] rollCounts = new int[13];

            // Simulate the specified number of rolls
            for (int i = 0; i < numberOfRolls; i++)
            {
                // Roll the first die (1-6)
                int die1 = random.Next(1, 7); // Next(1,7) gives 1,2,3,4,5,6

                // Roll the second die (1-6)
                int die2 = random.Next(1, 7);

                // Calculate the sum of both dice
                int sum = die1 + die2;

                // Increment the counter for this sum
                rollCounts[sum]++;
            }

            // Return the array with all the counts
            return rollCounts;
        }
    }
}