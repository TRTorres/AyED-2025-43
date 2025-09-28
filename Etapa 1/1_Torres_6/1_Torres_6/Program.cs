using System;

namespace _1_Torres_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int temperatura;
            Console.WriteLine("Ingrese la temperatura del agua");
            temperatura = Convert.ToInt32(Console.ReadLine());
            if (temperatura <= 0)
            {
                Console.WriteLine("El agua se congela");
            }
            else if (temperatura >= 100)
            {
                Console.WriteLine("El agua se hierve");
            }
            else
            {
                Console.WriteLine("El agua esta en estado liquido");
            }
        }
    }
}
