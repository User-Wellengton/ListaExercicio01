using System;

namespace Atividade_Leitor
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int idade;
            string nome;
            string opcao;
            int dias = 365;
            int totalDeDias;
            do
            {
                Console.WriteLine("Leitor de dados");

                Console.WriteLine("Digite 1 para realizar a operação ");

                Console.WriteLine("Digite s para sair");

                opcao = Console.ReadLine();

                if (opcao == "s")
                    break;

                Console.Write("Digite seu nome: ");
                nome = Console.ReadLine();


                Console.Write("Digitea sua idade: ");
                idade = Convert.ToInt32(Console.ReadLine());

                totalDeDias = dias * idade;


                Console.WriteLine(nome + ", você ja viveu " + totalDeDias + " dias.");

                Console.ReadLine();

            } while (opcao == "1");




        }
    }
}
