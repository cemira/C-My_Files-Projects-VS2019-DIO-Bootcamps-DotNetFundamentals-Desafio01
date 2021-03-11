using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Desafio
{
    static void Main()
    {
        // vetor N1.
        double[] N1 = new double[2];

        // variavel divisao.
        double divisao;

        
            // Entrada de dados do primeiro numero.
            Console.WriteLine("Digite o primeiro número: ");
            N1[0] = Double.Parse(Console.ReadLine());

            // Entrada de dados do segundo numero.
            Console.WriteLine("Digite o segundo número: ");
            N1[1] = Double.Parse(Console.ReadLine());

            // Laço para verificar a entrada de dados.
            if (N1[0] == 0)
            {
                Console.WriteLine("Divisao impossivel!");
                // Aviso de finalização do programa.
                Console.WriteLine("\r\n" + "Pressione qualquer tecla para fechar o app: ");
                Console.ReadKey();
                System.Environment.Exit(-1);
            }
            else if (N1[1] == 0)
            {
                Console.WriteLine("Divisao impossivel!");

                // Aviso de finalização do programa.
                Console.WriteLine("\r\n" + "Pressione qualquer tecla para fechar o app: ");
                Console.ReadKey();
                System.Environment.Exit(-1);
            }
            else
            {
                divisao = N1[0] / N1[1]; // Digite aqui o calculo da divisao
                Console.WriteLine("O resultado da divisao é: " + divisao);

                // Aviso de finalização do programa
                Console.WriteLine("\r\n" + "Pressione qualquer tecla para fechar o app: ");
                Console.ReadKey();
                System.Environment.Exit(0);
            }
    }
}
