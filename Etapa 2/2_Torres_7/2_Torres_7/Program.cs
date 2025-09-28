using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese el tamaño del vector: ");
        int n = int.Parse(Console.ReadLine());

        int[] vector = new int[n];
        Random rand = new Random();

        for (int i = 0; i < n; i++)
            vector[i] = rand.Next(1, 101);

        bool continuar = true;

        while (continuar)
        {
            Console.WriteLine("");
            Console.WriteLine("=== MENÚ ===");
            Console.WriteLine("1. Mostrar todos los elementos");
            Console.WriteLine("2. Buscar un número");
            Console.WriteLine("3. Ordenar vector");
            Console.WriteLine("4. Salir");
            Console.Write("Seleccione una opción: ");
            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("");
                    Console.WriteLine("Elementos del vector:");
                    for (int i = 0; i < vector.Length; i++)
                        Console.WriteLine("Posición " + i + ": " + vector[i]);
                    break;

                case 2:
                    Console.Write("Ingrese el número a buscar: ");
                    int buscado = int.Parse(Console.ReadLine());
                    bool encontrado = false;
                    for (int i = 0; i < vector.Length; i++)
                    {
                        if (vector[i] == buscado)
                        {
                            Console.WriteLine("Encontrado en la posición " + i);
                            encontrado = true;
                        }
                    }
                    if (!encontrado)
                        Console.WriteLine("No se encontró el número.");
                    break;

                case 3:
                    Console.Write("Ordenar ascendente (1) o descendente (2): ");
                    int tipo = int.Parse(Console.ReadLine());

                    for (int i = 0; i < vector.Length - 1; i++)
                        for (int j = i + 1; j < vector.Length; j++)
                        {
                            if ((tipo == 1 && vector[i] > vector[j]) ||
                                (tipo == 2 && vector[i] < vector[j]))
                            {
                                int temp = vector[i];
                                vector[i] = vector[j];
                                vector[j] = temp;
                            }
                        }

                    Console.WriteLine("Vector ordenado:");
                    for (int i = 0; i < vector.Length; i++)
                        Console.WriteLine("Posición " + i + ": " + vector[i]);
                    break;

                case 4:
                    Console.WriteLine("Programa finalizado.");
                    continuar = false;
                    break;

                default:
                    Console.WriteLine("Opción inválida.");
                    break;
            }
        }
    }
}