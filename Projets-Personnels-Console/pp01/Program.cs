using System;
using System.Globalization;

class URI
{
    static void Main(string[] args)
    {
        double dinheiro = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double produto = 7.75;

        double troco = dinheiro - produto;
        Console.WriteLine($"Seu troco é de {troco:F2}");

    }
}