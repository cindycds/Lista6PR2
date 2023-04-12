using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista6PR2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int menuzin;
            Console.WriteLine("1- exercicio 1");
            Console.WriteLine("2- exercicio 2");
            Console.WriteLine("3- exercicio 3");
            Console.WriteLine("4- exercicio 4");
            Console.WriteLine("5- exercicio 5");
            Console.WriteLine("6- exercicio 6");
            Console.WriteLine("7- exercicio 7");
            menuzin = int.Parse(Console.ReadLine());

            switch (menuzin)
            {
                case (1):
                    float quant, valor, totalval = 0, totalitens = 0, t;
                    for (; ; )
                    {
                        Console.WriteLine("Digite a quantidade do produto,quando quiser terminar digite 0:");
                        quant = float.Parse(Console.ReadLine());
                        if (quant <= 0)
                            break;

                        Console.WriteLine("Digite o  valor desses produto :");
                        valor = float.Parse(Console.ReadLine());

                        totalitens += quant;
                        totalval += quant * valor;

                    }
                    Console.WriteLine("a quandidade de produtos é:" + totalitens);
                    Console.WriteLine("o valor total da suacompra é:" + totalval);






                    break;

                case (2):
                    string nome, nomemaio = "", nomemenor = "";
                    int numitens, parada = 2;
                    float preco, menor, maior;

                    maior = float.MaxValue;
                    menor = float.MinValue;

                    for (; parada != 1;)
                    {
                        Console.WriteLine(" entre com o nome do produto");
                        nome = Console.ReadLine();

                        Console.WriteLine(" entre com o total de itens :");
                        numitens = int.Parse(Console.ReadLine());

                        Console.WriteLine("entrecom o preço unitario");
                        preco = float.Parse(Console.ReadLine());

                        float total = numitens * preco;
                        if (total > maior)
                        {
                            maior = total;
                            nomemaio = nome;

                        }
                        if (total < menor)
                        {
                            menor = total;
                            nomemenor = nome;
                        }

                        Console.WriteLine(" digite 1 para sair e 2 para continuar: ");
                        parada = int.Parse(Console.ReadLine());


                    }
                    Console.WriteLine("maior quantia investida {0} no produto {1}", maior, nomemaio);
                    Console.WriteLine("maior quantia investida {0} no produto {1}", menor, nomemenor);

                    break;
                case (3):

                    break;
                case (4):
                    break;
                case (5):
                    break;
                case (6):
                    break;
                case (7):
                    break;






                default:
                    Console.WriteLine("Opçao invalida");
                    break;
            }
            Console.ReadKey();
        }
    }
}