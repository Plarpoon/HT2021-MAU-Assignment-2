namespace _2A;

internal static class Program
{
    private static void Main()
    {
        Console.Title = "Selection and iteration in C#";
        _ = new SelectionAndIteration();
        Console.WriteLine("Press enter to continue!");
        Console.ReadLine();
        Console.Clear();

        Console.Title = "Fahrenheit and Celsius converter";
        _ = new TemperatureConverter();
    }
}