using System;

namespace JurosSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            // Calcule o montante final de um investimento a juros simples.
            //j = c . i . t
            //m = c + j

            Console.Clear();

            Decimal montante, tempo, taxaJuros, capital, juros;

            Console.WriteLine("Bem vindo a calculadora de Juros Simples!");

            Console.Write("\nCapital [c] (R$).......: ");
            capital = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Taxa de juros [i] (%)..: ");
            taxaJuros = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Tempo [t] (meses)......: ");
            tempo = Convert.ToDecimal(Console.ReadLine());

            juros = capital * (taxaJuros / 100) * tempo;
            montante = capital + juros;

            Console.WriteLine($"\nJuros (R$).....: {juros.ToString("C")}");
            Console.WriteLine($"Montante (R$)..: {montante.ToString("C")}");
        }
    }
}
