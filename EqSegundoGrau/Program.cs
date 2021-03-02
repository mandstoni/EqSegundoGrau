using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqSegundoGrau
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;

            Console.WriteLine("Equação do 2º");

            Console.Write("\nInforme o valor de a:" );
            a = double.Parse(Console.ReadLine());

            Console.Write("\nInforme o valor de b:");
            b = double.Parse(Console.ReadLine());

            Console.Write("\nInforme o valor de c:");
            c = double.Parse(Console.ReadLine());

            Bask1(a, b, c);
            Console.ReadKey();
        }

        static void Bask1(double a1, double b1, double c1)
        {
            double delta =( b1 * b1 - 4 * a1 * c1);

            Console.WriteLine(delta);

            double x1 = ((-b1 + Math.Sqrt(delta)) / (2 * a1));
            double x2 = ((-b1 - Math.Sqrt(delta)) / (2 * a1));

            if (delta > 0)
            {
                Console.WriteLine("x1 é igual a: " + x1 + " e x2 é igual a: " + x2);
            }
            else if(delta == 0)
            {
                Console.WriteLine("X1 e X2 é igual: " + x1);
            }
            else
            {
                Console.WriteLine("Não existe raiz, pois delta é menor que zero!");
            }
        }
    }
}
