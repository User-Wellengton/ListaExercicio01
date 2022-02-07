using System;

namespace Converter_temperatura
{
    internal class temperatura
    {
        static void Main(string[] args)
        {

            double fahrenheit = 32;
            int celsius;
            double conversao;
            string opcao;

            do
            {

                Console.WriteLine("Conversor de temperaturas");

                Console.WriteLine("Digite 1 para realizar a operação");

                Console.WriteLine("Digite s para sair");

                opcao = Console.ReadLine();

                if (opcao == "s")
                    break;

                Console.Write("Digitea a temperatura em Celsius: ");
                celsius = Convert.ToInt32(Console.ReadLine());

                conversao = (celsius * 1.8) + fahrenheit;

                Console.WriteLine(" A temperatura em Fahrenheit é de:  " + conversao + "f");

                Console.ReadLine();

            } while (opcao == "1");



        }
        
    }
}
