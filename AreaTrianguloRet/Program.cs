using System;

namespace AreaTrianTrianguloRet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Double baseTrian, alturaTrian, areaTrian;

            Console.WriteLine("Bem vindo ao calculo de area de triangulo retangulo");

            Console.WriteLine();

            Console.Write("Digite o valor da base..: ");
            baseTrian = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o valor da altura: ");
            alturaTrian = Convert.ToDouble(Console.ReadLine());

            areaTrian = (baseTrian * alturaTrian) / 2;

            Console.WriteLine($"\nBase: {baseTrian}. Altura: {alturaTrian}");
            Console.WriteLine($"Área: {areaTrian.ToString("N1")}");
        }
    }
}
