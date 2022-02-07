using System;

namespace Leitor_de_salario
{
    internal class Salario
    {
        static void Main(string[] args)
        {
            string opcao;
            double salarioInicial;
            double salarioAumento;
            double salarioFinal;


            do
            {

                Console.WriteLine("Demonstrador de Salario");

                Console.WriteLine("Digite 1 para realizar a operação");

                Console.WriteLine("Digite s para sair");

                opcao = Console.ReadLine();

                if (opcao == "s")
                    break;



                Console.Write("Digitea o salario inicial: ");
                salarioInicial = Convert.ToDouble(Console.ReadLine());

                salarioAumento = (salarioInicial * 0.15) + salarioInicial;

                salarioFinal = salarioAumento - (salarioAumento *0.08) ;
               

                Console.WriteLine("Salario inicial: R$" + salarioInicial);

                Console.WriteLine(" salario com aumento de 15%: R$ " + salarioAumento);

                Console.WriteLine("Salario final com 8% de desconto: R$" + salarioFinal);

                Console.ReadLine();

            } while (opcao == "1");


        }
    }
}
