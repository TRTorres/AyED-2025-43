using System;

namespace _1_Torres_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num_usu;
            Console.WriteLine("Escriba un numero entero positivo");
            num_usu = Convert.ToInt32(Console.ReadLine());
            for (int i = num_usu; i > 0; i--)
            {
                Console.WriteLine("El numero es " + i);
            }
            Console.WriteLine("El numero es " + 0);
        }
    }
}
