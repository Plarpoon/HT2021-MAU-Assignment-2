namespace _2A;

internal static class Program
{
    private static void Main()
    {
        Console.Title = "Selection and iteration in C#";
        _ = new SelectionAndIteration();

        Console.WriteLine("Press any key to continue!");
        Console.ReadLine();

        Console.Title = "Fahrenheit and Celsius converter";
        //TemperatureConverter converter = new TemperatureConverter();

        Console.WriteLine("Press any key to exit");
        Console.ReadLine();
        Environment.Exit(1);
    }
}