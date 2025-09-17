using System;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {
        double a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double Media = (a * 3.5 + b * 7.5) / 11.0;

        Console.WriteLine("MEDIA = " + Media.ToString("F5", CultureInfo.InvariantCulture));
    }

}