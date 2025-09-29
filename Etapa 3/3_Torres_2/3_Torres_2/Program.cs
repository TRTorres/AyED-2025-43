using System;

namespace CalculadoraSimple
{
    internal class Program
    {
        static int Sumar(int a, int b) => a + b;
        static int Restar(int a, int b) => a - b;
        static int Multiplicar(int a, int b) => a * b;
        static int Dividir(int a, int b) => a / b;

        static void Main(string[] args)
        {
            Console.WriteLine("Número 1:");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Número 2:");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Operación (+ - * /):");
            string op = Console.ReadLine();

            switch (op)
            {
                case "+":
                    Console.WriteLine(Sumar(x, y));
                    break;
                case "-":
                    Console.WriteLine(Restar(x, y));
                    break;
                case "*":
                    Console.WriteLine(Multiplicar(x, y));
                    break;
                case "/":
                    Console.WriteLine(Dividir(x, y));
                    break;
                default:
                    Console.WriteLine("Operación inválida");
                    break;
            }
        }
    }
}