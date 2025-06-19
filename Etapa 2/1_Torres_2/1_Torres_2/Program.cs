using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Torres_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int vueltas, cartotal, aux;
            Console.WriteLine("Ingrese la cantidad de vueltas que completo el Rayo");
            vueltas = Convert.ToInt32(Console.ReadLine());
            int[] tiempos = new int[vueltas];
            cartotal = 0;
            aux = 0;
            for (int i = 0; i < vueltas; i++)
            {
                Console.WriteLine("Ingrese el tiempo en el cual completo la vuelta " + i);
                tiempos[i] = Convert.ToInt32(Console.ReadLine());
                cartotal = cartotal + tiempos[i];
                for (int j = 0; j < vueltas; j++)
                {
                    aux = tiempos[i];
                    tiempos[i] = tiempos[j];
                    tiempos[j] = aux;
                }
            }
            Console.WriteLine("El promedio de tiempo por vuelta es " + (cartotal / vueltas));
            Console.WriteLine("El promedio de tiempo por vuelta es " + cartotal);
            Console.WriteLine("La mejor vuelta fue " + aux);
        }
    }
}
