//  This project is made for .NET 6 which is the default version on Windows 11
//  Thus using the new program style linked below
//  https://docs.microsoft.com/en-us/dotnet/core/tutorials/top-level-templates
using System;

namespace _2A
{
    internal static class Program
    {
        private static void Main()  //  I have made some alterations to the main method provided in the example as debugging would have taken far too long for the both of us
        {                           //  In case using a switch-case is not acceptable I'm willing to change it back ASAP
            var continueLoop = true;
            do
            {
                Console.WriteLine("Hello, Alex again here!\npress 1 for assignment 2A (Selection and iteration in C#)");
                Console.WriteLine("press 2 for assignment 2B (Fahrenheit and Celsius converter)");
                Console.WriteLine("press 3 for assignment 2C (Working schedule)");
                Console.WriteLine("press 0 to terminate the program gracefully");

                var input = Console.ReadLine();
                Console.Clear();
                switch (input)
                {
                    case "1":
                        {
                            Console.Title = "Selection and iteration in C#";
                            _ = new SelectionAndIteration();
                            break;
                        }
                    case "2":
                        {
                            Console.Title = "Fahrenheit and Celsius converter";
                            _ = new TemperatureConverter();
                            break;
                        }
                    case "3":
                        {
                            Console.Title = "Working Schedule";
                            _ = new WorkingSchedule();
                            break;
                        }
                    case "0":
                        {
                            continueLoop = false;
                            Environment.Exit(1);
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("\nplease try again..\n");
                            break;
                        }
                }
                Console.Clear();
            } while (continueLoop);
        }
    }
}