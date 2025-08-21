using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Torres_3
{
    class Program
    {
        /*static int crear_encargo(int[,] encargos)
        {
            Console.WriteLine("Escriba el codigo del camion asignado");
            encargos[1,1] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escriba la distancia que recorrera");
            encargos[1,2]= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escriba el origen de la sede");
            Console.WriteLine("1 es Buenos Aires");
            Console.WriteLine("2 es Bahia Blanca");
            Console.WriteLine("3 es Mar del Plata");
            encargos[1,3] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escriba la ganancia esperada por el encargo");
            encargos[1, 4] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escriba si el encargo esta asignado");
            Console.WriteLine("1 es Si");
            Console.WriteLine("0 es No");
            encargos[1, 5] = Convert.ToInt32(Console.ReadLine());
            return encargos[1,1], encargos[1,2], encargos[1,3], encargos[1,4], encargos[1,5];
        }*/
        static int Menu(int camio)
        {
            Console.WriteLine("Presione 1 para crear nuevo encargo");
            Console.WriteLine("Presione 2 mostrar todos los encargos");
            Console.WriteLine("Presione 3 para asignar un camion al encargo");
            Console.WriteLine("Presione 4 mostrar todos los encargos asignados");
            Console.WriteLine("Presione 5 mostrar promedio de ganacia por sede");
            Console.WriteLine("Presione 6 para mostrar encargo con mayor distancia");
            Console.WriteLine("Presione 7 para filtrar encargos por codigo de camion");
            camio = Convert.ToInt32(Console.ReadLine());
            return camio;
        }
        static int mostrar(int[,] encargos)
        {
            for (int i = 0; i < 25; i++)
            {
                Console.WriteLine(encargos[i, 1]);
                Console.WriteLine(encargos[i, 2]);
                Console.WriteLine(encargos[i, 3]);
                Console.WriteLine(encargos[i, 4]);
                Console.WriteLine(encargos[i, 5]);
            }
            return encargos[1, 1];
        }
        static void Main(string[] args)
        {
            int camio;
            camio = 0;
            int[,] encargos = new int[25, 5];
            int men = Menu(camio);
            switch(camio)
            {
                case 1:
                    /*int encargo = crear_encargo(encargos[1, 1], encargos[1, 2], encargos[1, 3], encargos[1, 4], encargos[1, 5]);*/
                    break;
                case 2:
                    int most = mostrar(encargos);
                    break;
            }
            Console.ReadKey();
        }
    }
}
