using System;

class Program
{
    static void Main()
    {
        Console.Write("Cantidad de participantes: ");
        int n = int.Parse(Console.ReadLine());

        int[] puntajes = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Puntaje participante {i + 1}: ");
            puntajes[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(puntajes);
        Array.Reverse(puntajes);

        Console.WriteLine("\nPuntajes (mayor a menor):");
        for (int i = 0; i < n; i++)
            Console.WriteLine($"{i + 1}. {puntajes[i]}");

        Console.WriteLine($"\nPrimer lugar: {puntajes[0]}");
        Console.WriteLine($"Último lugar: {puntajes[n - 1]}");
    }
}