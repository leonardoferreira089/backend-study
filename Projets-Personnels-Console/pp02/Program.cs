using System;
using System.Globalization;

class URI
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite o Valor A : ");
        int A = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o Valor B : ");
        int B = int.Parse(Console.ReadLine());
        int resultado = A * B;


        Console.WriteLine($"A multiplicação desses números é " + resultado);

    }
}