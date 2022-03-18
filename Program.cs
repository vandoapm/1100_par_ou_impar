using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1100_par_ou_impar
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Definir se valor é par ou impar");
            Console.WriteLine();

            Console.Write("digite o valor: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine();
            
            if (a % 2 == 0)
            {

                Console.WriteLine(a + " é par!!!");

            }
            else
            {
                Console.WriteLine(a + " é ímpar!!!");
            }


            Console.ReadLine();

        }
    }
}
