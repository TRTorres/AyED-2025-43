using System;

namespace _3_Torres_1
{
    internal class Program
    {
        static int PedirNumero()
        {
            Console.WriteLine("Escriba un número:");
            return Convert.ToInt32(Console.ReadLine());
        }

        static void Main(string[] args)
        {
            int num1 = PedirNumero();
            int num2 = PedirNumero();
            int suma = num1 + num2;

            Console.WriteLine("La suma de los dos números es: " + suma);
        }
    }
}