using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaliaçãoExc._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fig;
            Console.WriteLine("Escolha uma das figuras para o calculo da área: \n 1 - Losango; \n 2 - Circulo; \n 3 - Triangulo.");
            fig = Console.ReadLine();
            Console.WriteLine("\n-------------------------------------------------------");

            switch (fig)
            {
                case "1":
                    Console.WriteLine("Losango.");
                    double a, d1, d2;
                    Console.WriteLine("");
                    Console.WriteLine("Digite o valor da diagonal 1. ");
                    d1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Digite o valor da diagonal 2. ");
                    d2 = Convert.ToDouble(Console.ReadLine());
                    Console.Clear();
                    a = (d1 + d2) / 2;
                    Console.Write("A área do Losango é: " + a);
                    break;
                case "2":
                    Console.WriteLine("Circulo.");
                    double pi = 3.1416, r;
                    Console.WriteLine("Digite o valor do raio. ");
                    r = Convert.ToDouble(Console.ReadLine());
                    Console.Clear();
                    a = pi * (r * r);
                    Console.Write("A area do Circulo é: " + a);
                    break;
                case "3":
                    Console.WriteLine("Triângulo.");
                    double b, h;
                    Console.WriteLine("Digite o valor da base. ");
                    b = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Digite o valor da altura. ");
                    h = Convert.ToDouble(Console.ReadLine());
                    Console.Clear();
                    a = (b * h) / 2;
                    Console.Write("A área do Triângulo é: " + a);
                    break;
            }
            Console.ReadKey();


        }
    }
}

