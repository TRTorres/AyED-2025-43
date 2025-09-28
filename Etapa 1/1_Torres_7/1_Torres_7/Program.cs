using System;

namespace _1_Torres_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pal;
            Console.WriteLine("Escriba una palabra");
            pal = Console.ReadLine();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(pal);
            }
        }
    }
}
