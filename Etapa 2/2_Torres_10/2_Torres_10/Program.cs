using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese el tamaño n de las matrices: ");
        int n = int.Parse(Console.ReadLine());

        int[,] A = new int[n, n];
        int[,] B = new int[n, n];
        int[,] C = new int[n, n];

        Random r = new Random();

        // Llenar A y B con números aleatorios
        for (int i = 0; i < n; i++)
            for (int j = 0; j < n; j++)
            {
                A[i, j] = r.Next(1, 10);
                B[i, j] = r.Next(1, 10);
                C[i, j] = A[i, j] + B[i, j];
            }

        Console.WriteLine("Matriz A:");
        MostrarMatriz(A, n);

        Console.WriteLine("Matriz B:");
        MostrarMatriz(B, n);

        Console.WriteLine("Matriz C (A + B):");
        MostrarMatriz(C, n);
    }

    static void MostrarMatriz(int[,] M, int n)
    {
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
                Console.Write(M[i, j] + "\t");
            Console.WriteLine();
        }
    }
}