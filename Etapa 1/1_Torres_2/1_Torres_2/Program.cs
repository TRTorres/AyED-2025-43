using System;

namespace _1_Torres_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero_usu, num_usu, division;
            Console.WriteLine("Escribe un numero");
            numero_usu = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escribe otro numero");
            num_usu = Convert.ToInt32(Console.ReadLine()); 
            if (num_usu == 0)
            {
                Console.WriteLine("Error");
            }
            else
            { 
                division = 0;
                division = numero_usu / num_usu;
                Console.WriteLine("El resusltado de la division es: " + division);
            }
        }
    }
}
