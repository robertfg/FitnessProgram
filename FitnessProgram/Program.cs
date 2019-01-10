using System;

namespace FitnessTracker
{
    class Program
    {
        static void Main()
        {
            var runningTotal = 0.0;

            while (true)
            {
                // Prompt the user for minutes exercised
                Console.Write("Enter the number of minutes you have exercised or type \"quit\" to exit:  ");

                var entry = System.Console.ReadLine();

                // Quit loop if user types "quit"
                if ( entry.ToLower() == "quit" )
                {
                    break;
                }

                // Add minutes exercised to total
                try
                {
                    var minutes = double.Parse(entry);

                    // Print feedback message to screen
                    if (minutes <= 0)
                    {
                        Console.WriteLine(minutes + " is not an acceptable value.");
                        continue;
                    }
                    else if (minutes <= 10)
                    {
                        Console.WriteLine("Better than nothing, am I right?");
                    }
                    else if (minutes <= 30)
                    {
                        Console.WriteLine("Way to go hot stuff!");
                    }
                    else if (minutes <= 60)
                    {
                        Console.WriteLine("You must be a ninja warrior in training!");
                    }
                    else
                    {
                        Console.WriteLine("Okay, now you're just showing off!");
                    }

                    runningTotal += minutes;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }

                // Display total minutes exercised on screen
                Console.WriteLine("You've entered " + runningTotal + " minutes.");
            }

            // Let user know he's leaving
            Console.WriteLine("Goodbye.");

        }
    }
}
