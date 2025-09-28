using System;

namespace _1_Torres_0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int edad_usua;
            Console.WriteLine("Cuantos años tenes?");
            edad_usua = Convert.ToInt32(Console.ReadLine());
            if (edad_usua >= 18)
            {
                Console.WriteLine("Sos mayor de edad");
            }
            else
            {
                Console.WriteLine("Sos menor de edad");
            }
        }
    }
}
