using System;

namespace _1_Torres_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string comida, refugio, bate;
            Console.WriteLine("¿Tiene comida?");
            comida = Console.ReadLine().ToLower();
            Console.WriteLine("¿Tiene un refugio?");
            refugio = Console.ReadLine().ToLower();
            Console.WriteLine("¿Tiene un bate?");
            bate = Console.ReadLine().ToLower();
            if (comida == "si" && refugio == "si" && bate == "si")
            {
                Console.WriteLine("Puede sobrevivir");
            }
            else
            {
                Console.WriteLine("No puede sobrevivir");
            }

        }
    }
}
