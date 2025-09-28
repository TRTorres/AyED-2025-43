using System;

class Program
{
    static void Main()
    {
        Console.Write("Cantidad de productos: ");
        int n = int.Parse(Console.ReadLine());

        int max = int.MinValue;
        int min = int.MaxValue;

        for (int i = 0; i < n; i++)
        {
            Console.Write("Precio del producto " + (i+1) + " :");
            int precio = int.Parse(Console.ReadLine());

            if (precio > max) max = precio;
            if (precio < min) min = precio;
        }

        Console.WriteLine("Más caro: $" + max);
        Console.WriteLine("Más barato: $" + min);
    }
}