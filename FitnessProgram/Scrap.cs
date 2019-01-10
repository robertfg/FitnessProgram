using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scrappy
{
    class Scrap
    {
        static void temp()
        {
            string language = Console.ReadLine();

            if (language == "C#")
            {
                Console.WriteLine("C# Rocks!");
            }
            else
            {
                Console.WriteLine(language + " is not C#.");
            }
        }

        static void temp2()
        {

            string input = Console.ReadLine();
            int temperature = int.Parse(input);

            if (temperature < 21)
            {
                Console.WriteLine("Too cold!");
            }
            else if (temperature <= 22)
            {
                Console.WriteLine("Just right.");
            }
            else
            {
                Console.WriteLine("Too hot!");
            }

        }

        static void temp3()
        {
            //string input = "22";
            var input = "22";

            //int converted = int.Parse(input);
            var converted = int.Parse(input);

            //bool wheelsAreRound = true;
            var wheelsAreRound = true;

            //string downcased = "DoNuTs".ToLower();
            var downcased = "DoNuTs".ToLower();

            //bool success = (downcased == "donuts");
            var success = (downcased == "donuts");

            //double total = 0;
            var total = 0.0;
        }
    }
}
