using System;

namespace _0_Torres_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escribe tu nombre ");
            string nombre = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Escribe tu edad ");
            int edad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hola " + nombre + " tu edad es " + edad);
            Console.ReadKey();
        }
    }
}
