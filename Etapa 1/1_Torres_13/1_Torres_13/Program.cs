using System;

class algo
{
    static void Main()
    {
        int opcion = 0;

        Console.WriteLine("Bienvenido al programa!");

        while (opcion != 4)
        {
            Console.WriteLine("\n--- Menú ---");
            Console.WriteLine("1. Saludo");
            Console.WriteLine("2. Sumar 2 + 2");
            Console.WriteLine("3. Mostrar la hora");
            Console.WriteLine("4. Salir");
            Console.Write("Elija una opción: ");
            opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("¡Hola, Usuario!");
                    break;

                case 2:
                    Console.WriteLine("2 + 2 = 4");
                    break;

                case 3:
                    Console.WriteLine("Hora actual: " + DateTime.Now);
                    break;

                case 4:
                    Console.WriteLine("Adiós!");
                    break;
            }
        }
    }
}
