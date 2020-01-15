using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            // Req 2 - Two Variables
            string name = "Tanner Goodale";

            string location = "Missouri";

            // Req 3 - Intro
            Console.WriteLine("My name is {0}, I am from {1}.", name, location);

            // Req 4 - Date Without Small Time
            Console.WriteLine(DateTime.Now.ToString("dd,MM,yyyy"));

            // Req 5 - Days Until Christmas
            string someDate = "12-25-2020";

            DateTime christmasDay = DateTime.Parse(someDate);

            DateTime now = DateTime.Now;

            TimeSpan elapsed = christmasDay.Subtract(now);

            double daysTo = elapsed.TotalDays;

            Console.WriteLine("Christmas is {0} days away.", daysTo.ToString("0"));


            // Call GlazerCalc Class.
            GlazerCalc();

            // Pause The Program Until User Ends It
            Console.ReadLine();
        }

        static void GlazerCalc()
        {

            // Req 6 & 7 - Program From Book (With Text Lables)
            double width, height, woodLength, glassArea;

            string widthString, heightString;

            Console.WriteLine("Enter the width of the window in meters: ");

            widthString = Console.ReadLine();

            width = double.Parse(widthString);

            Console.WriteLine("Enter the height of the window in meters: ");

            heightString = Console.ReadLine();

            height = double.Parse(heightString);

            woodLength = 2 * (width + height) * 3.25;

            glassArea = 2 * (width * height);

            Console.WriteLine("The length of the wood is " + woodLength + " feet");

            Console.WriteLine("The area of the glass is " + glassArea + " square metres");

        }

    }

}
