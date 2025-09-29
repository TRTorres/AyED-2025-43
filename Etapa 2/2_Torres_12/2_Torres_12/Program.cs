using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese el tamaño n de la matriz: ");
        int n = int.Parse(Console.ReadLine());

        int[,] matriz = new int[n, n];
        int[] diagonal = new int[n];
        Random r = new Random();

        Console.WriteLine("Matriz generada:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                matriz[i, j] = r.Next(1, 100);
                Console.Write(matriz[i, j] + "\t");
            }
            Console.WriteLine();
        }

        for (int i = 0; i < n; i++)
            diagonal[i] = matriz[i, i];

        Console.WriteLine("Diagonal principal:");
        for (int i = 0; i < n; i++)
            Console.WriteLine("Posición " + i + ": " + diagonal[i]);
    }
}