using System;

namespace _3_Torres_0
{
    internal class Program
    {
        static void nombre()
        {
            string nombre;
            Console.WriteLine("Escribe tu nombre");
            nombre = Console.ReadLine();
            Console.WriteLine("Hola " + nombre);
        } 
        static void Main(string[] args)
        {
            nombre();
        }
    }
}
