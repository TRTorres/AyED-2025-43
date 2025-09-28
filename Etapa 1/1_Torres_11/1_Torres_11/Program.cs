using System;

namespace _1_Torres_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Escriba un numero");
            num = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < (num+1); i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
