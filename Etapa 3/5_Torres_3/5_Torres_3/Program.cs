using System;
class Program
{
    static void Main()
    {
        int hpHornet = 10;
        int hpMaxHornet = 10;
        int atkHornet = 3;
        int hpEnemigo = 12;
        Console.WriteLine("=== Hollow Knight: Simulador básico ===");
        while (hpHornet > 0 && hpEnemigo > 0)
        {
            MostrarEstado(hpHornet, hpEnemigo);
            Console.Write("\nAcción (atacar/curar/salir): ");
            string accion = Console.ReadLine();
            if (accion == "atacar")
            {
                hpEnemigo = Atacar(atkHornet, hpEnemigo);
            }
            else if (accion == "curar")
            {
                hpHornet = Curar(hpHornet, hpMaxHornet);
            }
            else if (accion == "salir")
            {
                break;
            }
            else
            {
                Console.WriteLine("Acción no válida.");

                //Hollow Knight 2


            }
            // Enemigo ataca automáticamente
            if (hpEnemigo > 0)
            {
                hpHornet -= 2;
                Console.WriteLine("El enemigo contraataca y hace 2 de daño!");
            }
        }
        Console.WriteLine("\n=== Resultado ===");
        if (hpHornet <= 0) Console.WriteLine("Hornet ha caído...");
        else if (hpEnemigo <= 0) Console.WriteLine("¡Hornet ganó!");
        else Console.WriteLine("Batalla interrumpida.");
    }
    // -------------------
    // ACA DEBEN CREAR LAS FUNCIONES:
    // 1) Atacar
    // 2) Curar
    // 3) MostrarEstado
    // -------------------
    static int Atacar(int atkHornet, int hpEnemigo)
    {
        hpEnemigo = hpEnemigo - 3;
        return hpEnemigo;
    }
    static int Curar(int hpHornet, int hpMaxHornet)
    {
        hpHornet = hpHornet + 5;
        if (hpHornet < 10)
        {
            hpHornet = 10;
        }
        return hpHornet;
    }
    static void MostrarEstado(int hpHornet, int hpEnemigo)
    {
        Console.WriteLine("El HP de Hornet es " + hpHornet);
        Console.WriteLine("El HP del enemigo es " + hpEnemigo);
    }
}