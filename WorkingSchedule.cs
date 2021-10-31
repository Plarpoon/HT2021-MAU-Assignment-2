//  This project is made for .NET 6 which is the default version on Windows 11
//  Thus using the new program style linked below
//  https://docs.microsoft.com/en-us/dotnet/core/tutorials/top-level-templates

using System;
using System.Collections.Generic;

namespace _2A
{
    //  Grade A assignment.
    internal class WorkingSchedule
    {
        private static string[] _arrayOfWeeks = Array.Empty<string>();
        private const int NumberOfMaxWeeks = 52;    //  Change this to adjust the number of weeks to calculate.
        private static int _startingWeek;
        private static int _frequency;

        internal WorkingSchedule()
        {
            MenuBuilder();      //  visualize the menu.
            PopulateArray();    //  load string array.
            MenuSelector();     //  add selectors.
        }

        private static void PopulateArray()
        {
            var listOfWeeks = new List<string>();
            for (var i = 1; i <= NumberOfMaxWeeks; i++)
            {
                listOfWeeks.Add("Week " + i);
                _arrayOfWeeks = listOfWeeks.ToArray();
            }
        }

        private static void MenuSelector()
        {
            var continueLoop = true;
            do
            {
                var input = Console.ReadLine();
                switch (input)
                {
                    case "1":   // Weekends to work.
                        {
                            _startingWeek = 2;
                            _frequency = 3;
                            Schedule();
                            break;
                        }
                    case "2":   // Nights to work.
                        {
                            _startingWeek = 1;
                            _frequency = 4;
                            Schedule();
                            break;
                        }
                    case "0":   //  Exit.
                        {
                            continueLoop = false;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("\nplease try again..\n");
                            break;
                        }
                }
            } while (continueLoop);
        }

        private static void Schedule()
        {
            Console.WriteLine();

            var nextJob = _frequency;

            var index = 1;  //  Init an index for the foreach.
            foreach (var week in _arrayOfWeeks)
            {
                if (index == _startingWeek) //  print the starting event.
                {
                    Console.WriteLine(week);
                }
                if (index == nextJob + _startingWeek)   //  print every next event.
                {
                    Console.WriteLine(week);
                    nextJob += _frequency;
                }
                index++;
            }
            Console.WriteLine();
            MenuBuilder();
        }

        private static void MenuBuilder()
        {
            Console.WriteLine("1 Show a list of the weekends to work.");
            Console.WriteLine("2 Show a list of the nights to work.");
            Console.WriteLine("0 Exit\n\nYour choice: ");
        }
    }
}