//  This project is made for .NET 6 which is the default version on Windows 11
//  Thus using the new program style linked below
//  https://docs.microsoft.com/en-us/dotnet/core/tutorials/top-level-templates
namespace _2A;

public class SelectionAndIteration
{
    internal SelectionAndIteration()
    {
        Console.WriteLine("My name is Alex, I am a student of the 'Fall 21' semester!\n");

        ShowStringLength();
        Console.WriteLine();

        MakeMyDay();
        Console.WriteLine();

        SumNumbers();
    }

    private static void SumNumbers()
    {
        //  Although I made big use of the 'convert' method in the previous assignment
        //  I opted to use a parsing method from now on instead as it does remove a lot of overhead.
        //  For that very same reason I'm streamlining the process.

        var smallerNumber = 0;
        var biggerNumber = 0;
        int input;
        double sumNumbers = 0;

        Console.WriteLine("Please enter a valid starting natural number");
        var continueLoop = true;
        do
        {
            if (!int.TryParse(Console.ReadLine(), out input))
            {
                Console.WriteLine("This is not a valid natural number! Please try again.");
            }
            else
            {
                smallerNumber = input;
                continueLoop = false;
            }
        } while (continueLoop);

        do
        {
            Console.WriteLine("Please enter another valid natural number");
            if (!int.TryParse(Console.ReadLine(), out input))
            {
                Console.WriteLine("This is not a valid natural number! Please try again.");
            }
            else
            {
                biggerNumber = input;
                continueLoop = false;
            }
        } while (continueLoop);

        if (smallerNumber < biggerNumber) goto Finish;  // Although shunned by many there are some exception in which the 'goto' statement does improve readability
        {                                               // like this example documented on Microsoft's Docs https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/goto.
            (smallerNumber, biggerNumber) = (biggerNumber, smallerNumber);  //  Swap of numbers via deconstruction.
        }

        Finish:
        Console.WriteLine();
        for (var i = smallerNumber; i <= biggerNumber; i++)
        {
            sumNumbers = i + i;
        }

        Console.WriteLine("The sum of the numbers between {0} and {1} is {2}", smallerNumber, biggerNumber, sumNumbers);
    }

    private static void MakeMyDay()
    {
        Console.WriteLine("Please input a number for 1 to 7\nWhere 1 corresponds to 'Monday' and 7 to 'Sunday'\n");

        var continueLoop = true;
        do
        {
            var inputText = Console.ReadLine();
            switch (inputText)
            {
                case "1":
                    {
                        Console.WriteLine("Monday: Keep calm! You can fall apart!");
                        continueLoop = false;
                        break;
                    }
                case "2":
                    {
                        Console.WriteLine("Tuesday and Wednesday break your heart!");
                        continueLoop = false;
                        break;
                    }
                case "3":   // Tuesday and Wednesday were on the same 'case' but we had to number the scenarios from 1 to 7, so I duplicated them.
                    {
                        Console.WriteLine("Tuesday and Wednesday break your heart!");
                        continueLoop = false;
                        break;
                    }
                case "4":
                    {
                        Console.WriteLine("Thursday, uuush, still one day to Friday!");
                        continueLoop = false;
                        break;
                    }
                case "5":
                    {
                        Console.WriteLine("It's Friday! You are in love!");
                        continueLoop = false;
                        break;
                    }
                case "6":
                    {
                        Console.WriteLine("Saturday, do nothing and do plenty of it!");
                        continueLoop = false;
                        break;
                    }
                case "7":
                    {
                        Console.WriteLine("And Sunday always comes too soon!");
                        continueLoop = false;
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Not in a good mood? This is not a valid date!\nPlease try again!");
                        break;
                    }
            }
        } while (continueLoop);                                                          //  The loop is required exclusively for those that will input in the Read buffer anything but a valid day of the week.
        Console.WriteLine("Well done! Press enter to continue to the next session!");    //  Essentially forcing them to comply if they don't want to remain stuck in the loop forever.
        Console.ReadLine();
        Console.Clear();
    }

    private static void ShowStringLength()
    {
        Console.WriteLine("Provide a text so that I can tell you how long it is and make it all capital!\nPress Enter without typing anything to exit this loop");
        var continueLoop = true;
        do
        {
            var textToElaborate = Console.ReadLine();
            var numberOfCharacters = textToElaborate?.Length;
            if (numberOfCharacters == 0) continueLoop = false;
            var upper = textToElaborate?.ToUpper();
            Console.WriteLine("All caps echo: " + upper);
            Console.WriteLine("The number of characters present in the phrase you provided is: {0}\n\n", numberOfCharacters);
        } while (continueLoop);

        Console.WriteLine("You pressed Enter without providing a text. See you again!\n\n");
    }
}