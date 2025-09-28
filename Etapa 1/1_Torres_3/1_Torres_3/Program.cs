using System;

namespace _1_Torres_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num_usu;
            Console.WriteLine("Escriba un numero");
            num_usu = Convert.ToInt32(Console.ReadLine());
            if (num_usu == 0)
            {
                Console.WriteLine("No se puede dividir un 0");
            }
            else if (num_usu % 2 == 0)
            {
                Console.WriteLine("El numero es par");
            }
            else
            {
                Console.WriteLine("El numero es impar");
            }
        }
    }
}
