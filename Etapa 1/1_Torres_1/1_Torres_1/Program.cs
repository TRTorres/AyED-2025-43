using System;

class Program
{
    static void Main()
    {
        string contraseña = "MiSecreta123";

        Console.Write("Introduce la contraseña: ");
        string entrada = Console.ReadLine();

        if (contraseña.ToLower() == entrada.ToLower())
        {
            Console.WriteLine("✅ Contraseña correcta.");
        }
        else
        {
            Console.WriteLine("❌ Contraseña incorrecta.");
        }
    }
}
