using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese el tamaño n de la matriz: ");
        int n = int.Parse(Console.ReadLine());

        int[,] matriz = new int[n, n];
        Random r = new Random();

        Console.WriteLine("Matriz original:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                matriz[i, j] = r.Next(1, 10);
                Console.Write(matriz[i, j] + "\t");
            }
            Console.WriteLine();
        }

        int[,] rotada = new int[n, n];
        for (int i = 0; i < n; i++)
            for (int j = 0; j < n; j++)
                rotada[j, n - 1 - i] = matriz[i, j];

        Console.WriteLine("Matriz rotada 90°:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
                Console.Write(rotada[i, j] + "\t");
            Console.WriteLine();
        }
    }
}