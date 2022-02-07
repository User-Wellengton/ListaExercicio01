using System;

namespace Atividade_Padaria
{
    public class Padaria
    {
        static void Main(string[] args)
        {
            int pao ;
            int broa ;
            double valorpao = 0.12;
                double valorbroa = 1.5;
            string opcao;
            double total = 0;

            do {
                Console.WriteLine("Calculo vendas pão e broa");

                Console.WriteLine("Digite 1 para realizar a operação ");

                Console.WriteLine("Digite s para sair");

                opcao = Console.ReadLine();

                if (opcao == "s")
                    break;

                Console.Write("Digite a quantidade da venda de pães: ");
                pao = Convert.ToInt32(Console.ReadLine());
              

                Console.Write("Digitea quantidade da venda de broas: ");
                broa = Convert.ToInt32(Console.ReadLine());

                total = (pao * valorpao) + (broa * valorbroa);

                Console.WriteLine("As vendas deram o valor de: R$" + total );

                Console.WriteLine("Deve guardar um total de 10%:  R$" + (total*0.10));

                Console.ReadLine();

            } while (opcao == "1");

        }
    }
}
