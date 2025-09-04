using System;
using System.Globalization;

class URI
{
    static void Main(string[] args)
    {
        double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double area = 3.14159 * (raio * raio);
        Console.WriteLine($"A={area:F4}");

    }
}