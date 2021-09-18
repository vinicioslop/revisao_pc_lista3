using System;

namespace Projetil
{
    class Program
    {
        static void Main(string[] args)
        {
            // Um projétil é lançado em um ângulo θ° (teta graus) a uma velocidade inicial v0 m/s. Calcule, em metros, o alcance máximo xmax e a altura máxima atingida hmax.

            // Para isso, precisamos:

            // Da constante π (pi) = 3,14159 radianos
            // Da constante g = 9,80665 m/s²
            // Converter o ângulo de graus para radianos, como no exemplo: 180° × π/180 = 3rad
            // Aplicar a Equação de Torricelli para o alcance, e
            // Aplicar a equação de Torricelli para a altura.

            Console.Clear();

            Double velocidade, angulo;
            Double altura, alcance;

            const Double PI = Math.PI;
            const Double g = 9.80665;

            Console.WriteLine("Bem vindo ao programa endemoniado de calculo do lançamento obliquo!\n");
            Console.WriteLine("-- Projétil --");
            Console.WriteLine();

            Console.Write("Entre com a velocidade, em m/s..: ");
            velocidade = Convert.ToDouble(Console.ReadLine());
            Console.Write("Entre com o ângulo, em graus....: ");
            angulo = Convert.ToDouble(Console.ReadLine());

            alcance = (Math.Pow(velocidade, 2) * Math.Sin((angulo*2) * (PI/180))) / g;
            altura = (Math.Pow((velocidade * Math.Sin(angulo * (PI/180))), 2)) / (2 * g);

            Console.WriteLine($"\nAlcance........: {alcance.ToString("N2")}");
            Console.WriteLine($"Altura máxima..: {altura.ToString("N2")}");
        }
    }
}
