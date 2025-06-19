using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_Torres_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int invitados, prom;
            Console.WriteLine("Ingrese la cantidad de invitados a la fiesta ");
            invitados = Convert.ToInt32(Console.ReadLine());
            int[] vect = new int[invitados];
            prom = 0;
            for (int i = 0; i < invitados; i++)
            {
                Console.WriteLine("Ingrese la cantidad de comida del invitado " + (i+1));
                vect[i] = Convert.ToInt32(Console.ReadLine());
                if (vect[i] > 100 && vect[i] < 0)
                {
                    Console.WriteLine("Numero no valido, intente devuelta ");
                    vect[i] = Convert.ToInt32(Console.ReadLine());
                }
                prom = prom + vect[i];
            }
            Console.WriteLine("El promedio de comida por invitado es " + (prom / invitados));
            Console.ReadKey();
        }
    }
}
