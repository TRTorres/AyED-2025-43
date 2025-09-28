using System;

namespace _1_Torres_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int edad, ayu;
            Console.WriteLine("Cual es su edad");
            edad = Convert.ToInt32(Console.ReadLine());
            ayu = 0;
            for (int i = 0; i < edad; i++)
            {
                ayu = ayu + 1;
                Console.WriteLine("Usted cumplio " + ayu + " años");
            }
        }
    }
}
