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

        bool running = true;
        while (running && hpHornet > 0 && hpEnemigo > 0)
        {
            MostrarEstado(hpHornet, hpEnemigo);
            Console.Write("\nAcción (atacar/curar/salir): ");
            string accion = Console.ReadLine();

            bool isAttack = accion == "atacar";
            bool isHeal = accion == "curar";
            bool isExit = accion == "salir";

            if (isAttack)
            {
                hpEnemigo = Atacar(atkHornet, hpEnemigo);
            }
            else if (isHeal)
            {
                hpHornet = Curar(hpHornet, hpMaxHornet);
            }
            else if (isExit)
            {
                running = false;
                break;
            }
            else
            {
                Console.WriteLine("Acción no válida.");
            }

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

    static int Atacar(int atkHornet, int hpEnemigo)
    {
        hpEnemigo -= atkHornet;
        if (hpEnemigo < 0) hpEnemigo = 0;
        Console.WriteLine("Hornet ataca y hace " + atkHornet + " de daño!");
        return hpEnemigo;
    }

    static int Curar(int hpHornet, int hpMaxHornet)
    {
        int heal = 5;
        hpHornet += heal;
        if (hpHornet > hpMaxHornet) hpHornet = hpMaxHornet;
        Console.WriteLine("Hornet se cura " + heal + " puntos de vida.");
        return hpHornet;
    }

    static void MostrarEstado(int hpHornet, int hpEnemigo)
    {
        Console.WriteLine("El HP de Hornet es " + hpHornet);
        Console.WriteLine("El HP del enemigo es " + hpEnemigo);
    }
}