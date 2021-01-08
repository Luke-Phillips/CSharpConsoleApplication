using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Luke";
            string location = "Idaho";
            Console.WriteLine($"My name is {name}");
            Console.WriteLine($"I live in {location}");

            DateTime currentDate = DateTime.Now;
            Console.WriteLine("The date is " + currentDate.ToString("d"));
            
            int year = int.Parse(currentDate.ToString("yyyy"));
            DateTime christmas = new DateTime(year, 12, 25, 0, 0, 0);
            int daysTilChristmas2021 = (christmas - currentDate).Days;

            // wanted to play with the ternary operator
            bool isDecember = daysTilChristmas2021 <= 25;
            bool isAtLeastOneDay = daysTilChristmas2021 > 1;
            string adverb = isDecember ? "only" : "still";
            string emote = isDecember ? ":D" : "Dx";
            string verbPlurality = isAtLeastOneDay ? "are" : "is";
            string nounPlurality = isAtLeastOneDay ? "s" : "";     
            Console.WriteLine($"There {verbPlurality} {adverb} {daysTilChristmas2021} day{nounPlurality} until Christmas! {emote}");

            // from "C# Programming Yellow Book" by Rob Miles. WriteLines added.
            double width, height, woodLength, glassArea;
            string widthString, heightString;
            Console.WriteLine("Width of window: ");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);
            Console.WriteLine("Height of window: ");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);
            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);
            Console.WriteLine("The length of the wood is " + woodLength + " feet");
            Console.WriteLine("The area of the glass is " + glassArea + " square metres");

            Console.ReadKey();
        }
    }
}
