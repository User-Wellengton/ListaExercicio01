using System;

namespace Atividades
{
    public class imobiliaria
    {
        static void Main(string[] args)

        {
            double largura = 0;
            double comprimento = 0;
            string opcao;
            double area = 0;

            do
            {
                Console.WriteLine("Vendas de terreno");

                Console.WriteLine("Digite 1 para realizar a operação");

                Console.WriteLine("Digite s para sair");

                opcao = Console.ReadLine();

                if (opcao == "s")
                    break;

                Console.Write("Digite a largura: ");
                largura = Convert.ToDouble(Console.ReadLine());

                Console.Write("Digite o comprimento: ");
                comprimento = Convert.ToDouble(Console.ReadLine());

                area = largura * comprimento;

                Console.WriteLine("a area do terreno é de :" + area +" m².");

                Console.ReadLine();

            } while (opcao == "1");


        }

        
    }
}
