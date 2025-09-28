using System;

class Program
{
    static void Main()
    {
        string nombre = "Jugador1";
        int salud = 100;
        int monedas = 50;
        int enemigosDerrotados = 0;
        bool tieneEspada = false;

        int opcion;

        do
        {
            Console.WriteLine("\n=== SIMULADOR GAMER ===");
            Console.WriteLine("1. Mostrar estado del jugador");
            Console.WriteLine("2. Encontrar espada mágica");
            Console.WriteLine("3. Pelear contra un enemigo");
            Console.WriteLine("4. Comprar poción de vida (vale 20 monedas)");
            Console.WriteLine("5. Salir del juego");
            Console.Write("Seleccione una opción: ");

            if (!int.TryParse(Console.ReadLine(), out opcion))
            {
                Console.WriteLine("Opción inválida. Elegí una opción del 1 al 5.");
                continue;
            }

            switch (opcion)
            {
                case 1:
                    Console.WriteLine($"\nNombre: {nombre}");
                    Console.WriteLine($"Salud: {salud}");
                    Console.WriteLine($"Monedas: {monedas}");
                    Console.WriteLine($"Enemigos derrotados: {enemigosDerrotados}");
                    Console.WriteLine($"¿Tiene espada mágica?: {(tieneEspada ? "Sí" : "No")}");
                    break;

                case 2:
                    if (tieneEspada)
                        Console.WriteLine("Ya tenés la espada mágica.");
                    else
                    {
                        tieneEspada = true;
                        Console.WriteLine("¡Encontraste la espada mágica!");
                    }
                    break;

                case 3:
                    if (tieneEspada)
                    {
                        salud -= 10;
                        enemigosDerrotados++;
                        Console.WriteLine("¡Ganaste la batalla! Salud -10.");
                    }
                    else
                    {
                        salud -= 30;
                        Console.WriteLine("¡Fue una pelea dura sin espada! Salud -30.");
                    }
                    break;

                case 4:
                    if (monedas >= 20)
                    {
                        monedas -= 20;
                        salud += 20;
                        Console.WriteLine("Usaste una poción. +20 de salud.");
                    }
                    else
                    {
                        Console.WriteLine("No tenés suficientes monedas.");
                    }
                    break;

                case 5:
                    Console.WriteLine("¡Gracias por jugar!");
                    break;

                default:
                    Console.WriteLine("Opción inválida. Elegí una opción del 1 al 5.");
                    break;
            }

        } while (opcion != 5);
    }
}
