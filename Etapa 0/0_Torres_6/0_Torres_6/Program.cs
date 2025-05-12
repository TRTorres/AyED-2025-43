using System;

namespace _0_Torres_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca un numero ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduzca otro numero ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int multi = num * num1;
            Console.WriteLine("La multiplicacion de ambos es " + multi);
        }
    }
}
