using System;

namespace _2_Torres_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            Console.WriteLine("Ingrese un numero");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese otro numero");
            num2 = Convert.ToInt32(Console.ReadLine());
            int[,] matriz = new int[num1, num2];
            Random random = new Random();
            for (int i = 0; i < num1; i++)
            {
                for (int j = 0; j < num2; j++)
                {
                    int rand = random.Next(1,101);
                    Console.WriteLine("La matriz en la posicion " + i + " y " + j + " sera " + rand);
                    matriz[i, j] = rand;
                }
            }
        }
    }
}
