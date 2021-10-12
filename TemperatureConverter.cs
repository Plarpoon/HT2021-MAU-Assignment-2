﻿using System.Text;

namespace _2A;

public class TemperatureConverter
{
    internal TemperatureConverter()
    {
        Console.OutputEncoding = Encoding.UTF8;
        MenuBuilder();
        MenuSelector();
    }

    private static void MenuBuilder()
    {
        Console.WriteLine("---------------------------\n\n");
        Console.WriteLine("TEMPERATURE CONVERTER");
        Console.WriteLine("\n\n---------------------------");
        Console.WriteLine("\n\nCelsius to Fahrenheit        : 1");
        Console.WriteLine("Fahrenheit to Celsius        : 2");
        Console.WriteLine("Exit                         : 0");
        Console.WriteLine("\n\n---------------------------");
        Console.WriteLine("\n\nYour choice:");
    }

    private static void MenuSelector()
    {
        var continueLoop = true;
        do
        {
            var input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    {
                        CelsiusToFahrenheit();
                        break;
                    }
                case "2":
                    {
                        FahrenheitToCelsius();
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
        } while (continueLoop);
    }

    private static void CelsiusToFahrenheit()
    {
        const double max = 100.00;

        for (var i = 0; i <= max; i++)   // I could change i++ with i+4 or i+5 for the alternatives asked by the assignment but I like it more with +1
        {
            var fahrenheit = (i * 1.8) + 32;
            fahrenheit = Math.Round(fahrenheit, 1);
            Console.WriteLine("{0}°C = {1}°F", i, fahrenheit);
        }

        Console.WriteLine("press Enter to continue.");
        Console.ReadLine();
        MenuBuilder();
    }

    private static void FahrenheitToCelsius()
    {
        const double max = 212.00;

        for (var i = 0; i <= max; i++)
        {
            var celsius = (i - 32) / 1.8;
            celsius = Math.Round(celsius, 1);
            Console.WriteLine("{0}°F = {1}°C", i, celsius);
        }

        Console.WriteLine("press Enter to continue.");
        Console.ReadLine();
        MenuBuilder();
    }
}