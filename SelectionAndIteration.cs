﻿namespace _2A;

public class SelectionAndIteration
{
    public SelectionAndIteration()
    {
        Console.WriteLine("My name is: Alex, I am a student of the 'winter 21' semester!\n");

        ShowStringLenght();
        Console.WriteLine();

        MakeMyDay();
        Console.WriteLine();

        SumNumbers();
    }

    private static void SumNumbers()
    {
        throw new NotImplementedException();
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
                case "3":
                    {
                        Console.WriteLine("Thursday, uuush, still one day to Friday!");
                        continueLoop = false;
                        break;
                    }
                case "4":
                    {
                        Console.WriteLine("It's Friday! You are in love!");
                        continueLoop = false;
                        break;
                    }
                case "5":
                    {
                        Console.WriteLine("Saturday, do nothing and do plenty of it!");
                        continueLoop = false;
                        break;
                    }
                case "6":
                    {
                        Console.WriteLine("And Sunday always comes too soon!");
                        continueLoop = false;
                        break;
                    }
                case "7":
                    {
                        Console.WriteLine("Not in a good mood? This is not a valid date!");
                        continueLoop = false;
                        break;
                    }
                default:
                    {
                        Console.WriteLine("You didn't input a valid day of the week\nPlease try again!"); break;
                    }
            }
        } while (continueLoop); //  The loop is required exclusively for those that will input in the Read buffer anything but a valid day of the week.
    }                           //  Essentially forcing them to comply if they don't want to remain stuck in the loop forever.

    private static void ShowStringLenght()
    {
        Console.WriteLine("Provide a text so that I can tell you how long it is and make it all capital!");
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
        Console.ReadLine();
        Console.Clear();
    }
}