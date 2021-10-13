//  This project is made for .NET 6 which is the default version on Windows 11
//  Thus using the new program style linked below
//  https://docs.microsoft.com/en-us/dotnet/core/tutorials/top-level-templates

using System.Diagnostics;

namespace _2A;

//  Grade A assignment.
internal class WorkingSchedule
{
    private static string[]? _arrayOfWeeks;
    private const int NumberOfMaxWeeks = 52;
    private static int _startingWeek;
    private static int _frequency;

    internal WorkingSchedule()
    {
        MenuBuilder();
        MenuSelector();
        PopulateArray();
        Schedule();
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
                case "1":   // Weekends to work
                    {
                        _startingWeek = 2;
                        _frequency = 3;
                        continueLoop = false;
                        break;
                    }
                case "2":   // Nights to work
                    {
                        _startingWeek = 1;
                        _frequency = 4;
                        continueLoop = false;
                        break;
                    }
                case "0":
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
        Debug.Assert(_arrayOfWeeks != null, nameof(_arrayOfWeeks) + " != null");    // This array cannot be null, here I'm stating that.
        Console.WriteLine();

        var nextJob = _frequency;

        var index = 1;
        foreach (var week in _arrayOfWeeks)
        {
            if (index == _startingWeek)
            {
                Console.WriteLine(week);
            }
            if (index == nextJob + _startingWeek) //  +1 required as the cycle is not over yet and the addition is done only at the end.
            {
                Console.WriteLine(week);
                nextJob += _frequency;
            }
            index++;
        }

        Console.WriteLine("\npress enter to continue");
        Console.ReadLine();

        Console.Clear();
        _ = new WorkingSchedule();
    }

    private static void MenuBuilder()
    {
        Console.WriteLine("1 Show a list of the weekends to work.");
        Console.WriteLine("2 Show a list of the nights to work.");
        Console.WriteLine("0 Exit\n\nYour choice: ");
    }
}