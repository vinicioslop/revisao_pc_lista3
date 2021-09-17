using System;

namespace Medidas
{
    class Program
    {
        static void Main(string[] args)
        {
            // Receba uma medida em metros e exiba seus equivalentes em quilômetros e centímetros.

            // DECLARA AS VARIÁVEIS DE METROS, CENTIMETROS E KILOMETROS, NO FORMATO DOUBLE
            Double metros = 0;
            Double cm = 0;
            Double km = 0;

            // EXIBE MENSAGEM PARA O USUÁRIO
            Console.WriteLine("Bem vindo ao convesor de metros em Km e cm!");

            // PULA UMA LINHA NO TERMINAL
            Console.Write("\n");

            // EXIBE MENSAGEM PARA O USUÁRIO DIGITAR UM VALOR EM METROS
            Console.Write("Digite a media em metros: ");
            // LE O DADO DO USUÁRIO NO FORMATO DE STRING
            // CONVERTE A STRING PARA O DOUBLE (DECIMAL)
            // ATRIBUI O VALOR CONVERTIDO NA VARIÁVEL METROS
            metros = Double.Parse(Console.ReadLine());

            // PEGA O VALOR EM METROS, MULTIPLICA POR 100 E INSERE NA VARIAVEL CM
            cm = metros * 100;
            // PEGA O VALOR EM METROS, DIVIDE POR 1000 E INSERE NA VARIAVEL KM
            km = metros / 1000;

            // EXIBE PARA O USUÁRIO OS RESULTADOS DAS CONTAS
            // USA DA INTERPOLAÇÃO PARA ESCREVER UMA VARIAVEL DENTRO DE UM TRECHO DE TEXTO
            //  COLOCANDO OS VALORES DENTRO DE {}
            Console.WriteLine($"\n--- Equivalência ---\n{cm} cm \n{metros} m \n{km} Km");
        }
    }
}
