using System;

namespace GrausCF
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Double celsius, fahr;

            Console.WriteLine("Bem vindo ao conversor de graus C° em F°!");

            Console.Write("\nDigite o valor em graus celsius: ");
            celsius = Convert.ToDouble(Console.ReadLine());

            fahr = celsius * 1.8 + 32;

            Console.WriteLine($"\n{celsius}° equivale a {fahr}°F");
        }
    }
}
