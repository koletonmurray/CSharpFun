using System;

namespace CSharpFun
{
    class Program
    {
        static void Main(string[] args)
        {
            // Brings in the Random library/class
            Random r = new Random();

            // Set up the rolls array to monitor number of times a number is rolled
            int[] rolls = new int[11];

            for (int i = 0; i < 11; i++)
            {
                rolls[i] = 0;
            }

            // Prompt the user for the number of rolls
            Console.WriteLine("Welcome to the dice throwing simulator!");
            Console.WriteLine("");
            Console.WriteLine("How many dice rolls would you like to simulate?");
            double numRolls = Convert.ToDouble(Console.ReadLine());

            int die1 = 0;
            int die2 = 0;

            // For each roll simulate rolling die1 and die2 and assign and update the rollcount array
            for (int i = 0; i < numRolls; i++)
            {
                die1 = (r.Next(1, 7));
                die2 = (r.Next(1, 7));
                rolls[die1 + die2 - 2]++;
                die1 = 0;
                die2 = 0;
            }

            // Print out the results of the rolls
            Console.WriteLine("");
            Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
            Console.WriteLine("Each ' * ' represents 1% of the total number of rolls.");
            Console.WriteLine(string.Concat("Total number of rolls = ", numRolls, "."));
            Console.WriteLine("");

            // Calculate and output astrix based on percentage of rolls
            for (int i = 0; i < 11; i++)
            {
                string astrix = "";
                double percent = 0;
                percent = (rolls[i]) / numRolls * 100;
                percent = (int)Math.Round(percent);

                for (int j = 0; j < percent; j++)
                {
                    astrix += "*";
                }

                // Output the results for each roll combination 2 - 12
                Console.WriteLine(string.Concat((i + 2).ToString("D2"), ": ", astrix));
            }

            // Thank the user and tada it's done!
            Console.WriteLine("");
            Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");
        }
    }
}
