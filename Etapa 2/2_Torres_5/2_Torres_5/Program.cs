using System;

class Program
{
    static void Main()
    {
        Console.Write("Cantidad de objetos: ");
        int cantidad = Convert.ToInt32(Console.ReadLine());

        Console.Write("Valor mínimo para filtrar: ");
        int minimo = Convert.ToInt32(Console.ReadLine());

        int[] valores = new int[cantidad];

        for (int i = 0; i < cantidad; i++)
        {
            Console.Write("Valor del objeto " + (i+1) + ":");
            valores[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("Posiciones con valor mayor al mínimo:");
        for (int i = 0; i < cantidad; i++)
        {
            if (valores[i] > minimo)
                Console.WriteLine("Posición " + (i + 1) + " Valor: " + valores[i]);
        }
    }
}