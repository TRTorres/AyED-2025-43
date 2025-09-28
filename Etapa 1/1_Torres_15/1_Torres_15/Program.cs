using System;

class Program
{
    static void Main()
    {
        int salud = 100;
        int hambre = 50;
        int energia = 70;
        int dia = 1;
        bool sigueVivo = true;
        Random rand = new Random();

        while (sigueVivo && dia <= 7)
        {
            Console.WriteLine($"\nDía {dia} – ¿Qué querés hacer?");
            Console.WriteLine("1. Buscar comida");
            Console.WriteLine("2. Dormir");
            Console.WriteLine("3. Explorar la isla");
            Console.WriteLine("4. Ver estado del personaje");
            Console.WriteLine("5. Salir del juego");
            Console.Write("Elija una opción: ");

            if (!int.TryParse(Console.ReadLine(), out int opcion))
            {
                Console.WriteLine("Opción inválida. Elegí una opción del 1 al 5.");
                continue;
            }

            switch (opcion)
            {
                case 1: 
                    hambre += 20;
                    energia -= 15;
                    Console.WriteLine("Buscaste comida: Hambre +20, Energía -15.");
                    int pComida = rand.Next(1, 101);
                    if (pComida <= 30)
                    {
                        salud -= 15;
                        Console.WriteLine("Comiste algo en mal estado. Salud -15.");
                    }
                    break;

                case 2: 
                    energia += 30;
                    hambre -= 10;
                    Console.WriteLine("Dormiste: Energía +30, Hambre -10.");
                    break;

                case 3: 
                    energia -= 20;
                    hambre -= 15;
                    Console.WriteLine("Exploraste la isla: Energía -20, Hambre -15.");
                    int pPlanta = rand.Next(1, 101);
                    if (pPlanta <= 50)
                    {
                        salud += 10;
                        Console.WriteLine("¡Encontraste una planta curativa! Salud +10.");
                    }
                    break;

                case 4: 
                    Console.WriteLine($"\nEstado actual:");
                    Console.WriteLine($"Día: {dia}");
                    Console.WriteLine($"Salud: {salud}");
                    Console.WriteLine($"Hambre: {hambre}");
                    Console.WriteLine($"Energía: {energia}");
                    break;

                case 5: 
                    Console.WriteLine("Saliste del juego.");
                    sigueVivo = false;
                    break;

                default:
                    Console.WriteLine("Opción inválida. Elegí una opción del 1 al 5.");
                    break;
            }

            
            if (salud > 100) salud = 100;
            if (energia > 100) energia = 100;
            if (hambre > 100) hambre = 100;

            
            if (opcion != 4 && opcion != 5 && sigueVivo)
            {
                if (salud <= 0 || hambre <= 0 || energia <= 0)
                {
                    Console.WriteLine("Te desmayaste y no pudiste sobrevivir... Game Over ☠️");
                    sigueVivo = false;
                }
                else
                {
                    dia++; 
                }
            }
        }

        if (sigueVivo && dia > 7)
        {
            Console.WriteLine("\n¡Felicidades! Sobreviviste 7 días en la isla.");
            Console.WriteLine($"Estado final - Salud: {salud}, Hambre: {hambre}, Energía: {energia}");
        }

        Console.WriteLine("Fin del juego.");
    }
}
