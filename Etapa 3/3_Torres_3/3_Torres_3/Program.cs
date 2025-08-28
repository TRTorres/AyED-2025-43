using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Torres_3
{
    class Program
    {
        static int cod_camio(int[,] encargos)
        {
            Console.WriteLine("Escriba el codigo del camion asignado");
            return encargos[1, 1];
        }
        static int dist_recorrida(int[,] encargos)
        {
            Console.WriteLine("Escriba la distancia que recorrera");
            return encargos[1, 2];
        }
        static int origen_sede(int[,] encargos)
        {
            Console.WriteLine("Escriba el origen de la sede" + "\n" + "1 es Buenos Aires" + "\n" + "2 es Bahia Blanca" + "\n" + "3 es Mar del Plata");
            return encargos[1, 3];
        }
        static int ganancia(int[,] encargos)
        {
            Console.WriteLine("Escriba la ganancia esperada por el encargo");
            return encargos[1, 4];
        }
        static int encargos_asig(int[,] encargos)
        {
            Console.WriteLine("Escriba si el encargo esta asignado" + "\n" + "1 es Si" + "\n" + "0 es No");
            return encargos[1, 5];
        }
        static int asignar(int[,] encargos, int cod)
        {
            Console.WriteLine("Escriba el codigo del camion que quiere asignarle un encargo");
            cod = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < 25; i++)
            {
                if (cod == encargos[i, 1])
                {
                    Console.WriteLine("El encargo ya se ha cambiado a asignado");
                }
            }
            return cod;
        }
        static void mostrar_encargos_asig(int[,] encargos)
        {
            for (int i = 0; i < 25; i++)
            {
                if(encargos[i,5]==1)
                {
                    Console.WriteLine("El encargo " + encargos[i, 1] + " esta asignado");
                }
            }
        }
        static void promedio_sede(int[,] encargos)
        {
            int promedio_bsas = 0;
            int promedio_bb = 0;
            int promedio_mdp = 0;
            for (int i = 0; i < 25; i++)
            {
                if(encargos[i,3] == 1)
                {
                    promedio_bsas = promedio_bsas + encargos[i, 4];
                }
                else if (encargos[i,3] == 2)
                {
                    promedio_bb = promedio_bb + encargos[i, 4];
                }
                else if (encargos[i, 3] == 3)
                {
                    promedio_mdp = promedio_mdp + encargos[i, 4];
                }
            }
            Console.WriteLine("El promedio de Buenos Aires es" + promedio_bsas + "\n" + "El promedio de Bahia Blanca es " + promedio_bb + "\n" + "El promedio de Mar del Plata es " + promedio_mdp);
        }
        static void Menu(int camio)
        {
            Console.WriteLine("----------Presione 1 para crear nuevo encargo--------------");
            Console.WriteLine("---------Presione 2 mostrar todos los encargos-------------");
            Console.WriteLine("------Presione 3 para asignar un camion al encargo---------");
            Console.WriteLine("-----Presione 4 mostrar todos los encargos asignados-------");
            Console.WriteLine("-----Presione 5 mostrar promedio de ganacia por sede-------");
            Console.WriteLine("----Presione 6 para mostrar encargo con mayor distancia----");
            Console.WriteLine("---Presione 7 para filtrar encargos por codigo de camion---");
            Console.WriteLine("------------------Presione 8 para salir--------------------");
        }
        static void mostrar(int[,] encargos)
        {
            for (int i = 0; i < encargos.GetLength(0); i++)
            {
                for (int j = 0; j < encargos.GetLength(1); j++)
                {
                    Console.Write(encargos[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        static void mayor_dist(int[,] encargos)
        {
            int comodin = 0;
            for (int i = 0; i < 25; i++)
            {
                for (int j= 0; j < 25; j++)
                {
                    encargos[j, 2] = comodin;
                    encargos[j, 2] = encargos[i, 2];
                    encargos[i, 2] = comodin;
                }
            }
            Console.WriteLine("La distancia mas larga recorrida en el camion es de " + encargos[1, 2]);
        }
        static void filtrar_encargos(int[,] encargos)
        {
            int cod = 0;
            for (int i = 0; i < 25; i++)
            {
                if (encargos[i,1] == cod)
                {
                    if (encargos[i,5] == 1)
                    { 
                    Console.WriteLine("El camion " + encargos[i, 1] + " tiene un encargo asignado");
                    }
                    if (encargos[i, 5] == 0)
                    {
                        Console.WriteLine("El camion " + encargos[i, 1] + " no tiene un encargo asignado");
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            int camio, cod;
            camio = 0;
            cod = 0;
            int[,] encargos = {
            {1, 2, 3, 4, 5, 6},
            {7, 8, 9, 10, 11, 12},
            {13, 14, 15, 16, 17, 18},
            {19, 20, 21, 22, 23, 24},
            {25, 26, 27, 28, 29, 30},
            };
            Menu(camio);
            camio = Convert.ToInt32(Console.ReadLine());
            switch (camio)
            {
                case 1:
                    cod_camio(encargos);
                    encargos[1, 1] = Convert.ToInt32(Console.ReadLine());
                    dist_recorrida(encargos);
                    encargos[1, 2] = Convert.ToInt32(Console.ReadLine());
                    origen_sede(encargos);
                    encargos[1, 3] = Convert.ToInt32(Console.ReadLine());
                    ganancia(encargos);
                    encargos[1, 4] = Convert.ToInt32(Console.ReadLine());
                    encargos_asig(encargos);
                    encargos[1, 5] = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    break;
                case 2:
                    mostrar(encargos);
                    Console.Clear();
                    break;
                case 3:
                    asignar(encargos, cod);
                    for (int i = 0; i < 25; i++)
                    {
                        if (cod == encargos[i,1])
                        {
                            encargos[i, 5] = 1;
                        }
                    }
                    break;
                case 4:
                    mostrar_encargos_asig(encargos);
                    break;
                case 5:
                    promedio_sede(encargos);
                    break;
                case 6:
                    mayor_dist(encargos);
                    break;
                case 7:
                    filtrar_encargos(encargos);
                    break;
                case 8:
                    Console.WriteLine("Presione enter");
                    Console.ReadKey();
                    break;
            }
        }
    }
}
