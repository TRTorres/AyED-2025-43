using System;

namespace _0_Torres_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca un numero ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduzca otro numero ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int resto = num % num1;
            int resto1 = num1 % num;
            Console.WriteLine("El resto de la division del segundo al primero es " + resto);
            Console.WriteLine("El resto de la division del primero al segundo es " + resto1);
        }
    }
}
