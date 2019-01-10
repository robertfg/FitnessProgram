using System;

namespace FitnessTracker.PreRefactor
{
    class Program
    {
        static void Main()
        {
            //int runningTotal = 0;
            // Validate for fractional values
            double runningTotal = 0;
            bool keepGoing = true;

            while(keepGoing)
            {
                // Prompt the user for minutes exercised
                //System.Console.Write("Enter the number of minutes you have exercised:  ");
                //Console.Write("Enter the number of minutes you have exercised or type 'quit' to exit:  ");

                // Escape the quotes:
                Console.Write("Enter the number of minutes you have exercised or type \"quit\" to exit:  ");

                string entry = System.Console.ReadLine();

                // Validate for someone entering upper case characters
                if ( entry.ToLower() == "quit" )
                {
                    keepGoing = false;
                }
                else
                {
                    try
                    {
                        // Add minutes exercised to total
                        //int minutes = int.Parse(entry);

                        // Validate for fractional values:
                        double minutes = double.Parse(entry);

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

                        runningTotal = runningTotal + minutes;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Invalid input!");
                        continue;
                    }

                    // Display total minutes exercised on screen

                    /*Console.Write("You've entered ");
                    Console.Write(entry);
                    Console.WriteLine(" minutes.");*/

                    //System.Console.WriteLine("You've entered " + entry + " minutes.");
                    //Console.WriteLine("You've entered " + entry + " minutes.");
                    Console.WriteLine("You've entered " + runningTotal + " minutes.");
                }

                // Repeat until user quits
            }

            // Let user know he's leaving
            Console.WriteLine("Goodbye.");

        }
    }
}
