using System;

class Program
{
    static void Main()
    {
        string respuesta;

        do
        {
            Console.Write("¿Desea terminar el programa? ");
            respuesta = Console.ReadLine();
        }
        while (respuesta != "SI");

        Console.WriteLine("Programa finalizado.");
    }
}
