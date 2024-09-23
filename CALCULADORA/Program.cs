using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CALCULADORA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //calculadora usando estruturas de controles
            Console.WriteLine("----CALCULADORA----");
            Console.Write("Digite um número: ");
            int numero1 = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            int numero2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Escolha a opção: (+ - x / )");
            string escolha = Console.ReadLine();
            double resultado;

            while (escolha != "+" && escolha != "-" & escolha != "x" & escolha != "/")
            {
                Console.WriteLine("Opçao Invalida!! ");
                Console.Write("Escolha a opção: (+ - x / ): ");
                escolha = Console.ReadLine();
            }
            switch (escolha)
            {
                case "+":
                    resultado = numero1 + numero2;
                    Console.WriteLine($"O resultado de {numero1} + {numero2} = {resultado}");
                    break;
                case "-":
                    resultado = numero1 - numero2;
                    Console.WriteLine($"O resultado de {numero1} - {numero2} = {resultado}");
                    break;
                case "x":
                    resultado = numero1 * numero2;
                    Console.WriteLine($"O resultado de {numero1} X {numero2} = {resultado}");
                    break;
                case "/":
                    if(numero2 == 0)
                    {
                        Console.WriteLine("Divisão com 0 não é valida!");
                    }
                    else
                    {
                        resultado = (double)numero1 / numero2;
                        Console.WriteLine($"O resultado de {numero1} / {numero2} = {resultado}"); 
                    }
                    break;
            }

            Console.ReadKey();
        }
    }
}
