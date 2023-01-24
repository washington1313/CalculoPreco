using System;

namespace CalculoPreco
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double produto, desconto, valorFinal;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Informe o Valor do produto: ");
            produto= Double.Parse(Console.ReadLine());
            Console.ResetColor();
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Informe o Valor do desconto: ");
            desconto = Double.Parse(Console.ReadLine());
            Console.ResetColor();
            Console.Clear();

            valorFinal = produto - desconto;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("O valor a ser pago: "+ valorFinal);
            Console.ResetColor();

            Console.ReadLine();
        }
    }
}
