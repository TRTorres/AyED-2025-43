using System;

class Program
{
    static void Main()
    {
        Console.Write("Cantidad de candidatos: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int[] puntajes = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write("Puntaje del candidato " + (i+1) +":");
            puntajes[i] = Convert.ToInt32(Console.ReadLine());
        }

        Array.Sort(puntajes); 

        Console.Write("Número para filtrar múltiplos: ");
        int filtro = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Puntajes ordenados:");
        for (int i = 0; i < n; i++)
            Console.WriteLine(puntajes[i]);


        Console.WriteLine("Puntajes múltiplos de " + filtro + ":");
        for (int i = 0; i < n; i++)
            if (puntajes[i] % filtro == 0)
                Console.WriteLine(puntajes[i]);

    }
}