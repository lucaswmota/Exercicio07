using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio07
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Informe quanto vai colocar em R$ de combustivel: ");
                double valor = double.Parse(Console.ReadLine());

                if (valor > 0)
                {
                    Console.WriteLine("Informe o combustivel utilizado: " +
                    "\n (E) para Etanol" +
                    "\n (G) para Gasolina" +
                    "\n (D) para Diesel");
                    string combustivel = Console.ReadLine().ToUpper();

                    if (combustivel == "E")
                    {
                        double total = valor / 2.69;
                        Console.WriteLine("Voce vai abastecer " + total.ToString("F2") + " litros de Etanol.");
                    }
                    else if (combustivel == "G")
                    {
                        double total = valor / 3.59;
                        Console.WriteLine("Voce vai abastecer " + total.ToString("F2") + " litros de Gasolina.");
                    }
                    else if (combustivel == "D")
                    {
                        double total = valor / 3.29;
                        Console.WriteLine("Voce vai abastecer " + total.ToString("F2") + " litros de Diesel");
                    }
                    else
                    {
                        Console.WriteLine("Entre com os Dados (E), (D) ou (G) para escolher o combustivel." +
                            "\nPrograma encerrado.");
                    }
                }
                else
                {
                    Console.WriteLine("Insira um valor maior do que 0 (Zero).");
                }
            }
            catch(System.FormatException)
            {
                Console.Write("Entre com os Dados(E), (D) ou (G) para escolher o combustivel." +
                        "\nPrograma encerrado.");
                Console.Write("Utilize apenas numeros para definir o valor.");
            }
            finally
            {
                Console.WriteLine("Programa encerrado.");
                Console.ReadKey();
            }
            
        }

    }
}
