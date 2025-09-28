using System;

namespace _1_Torres_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int edad, ingresos;
            Console.WriteLine("Escriba su edad");
            edad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escriba sus ingresos mensuales");
            ingresos = Convert.ToInt32(Console.ReadLine());
            if (edad > 19 && ingresos <= 100000)
            {
                Console.WriteLine("Puede cobrar la beca");
            }
            else if (edad < 19 && ingresos == 0)
            {
                Console.WriteLine("Puede cobrar la beca");
            }
            else if (edad == 19 && ingresos <= 50000)
            {
                Console.WriteLine("Puede cobrar la beca");
            }
        }
    }
}
