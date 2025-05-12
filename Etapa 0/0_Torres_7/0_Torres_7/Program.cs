using System;

namespace _0_Torres_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca un numero ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduzca otro numero ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int div = num / num1;
            int div1 = num1 / num;
            Console.WriteLine("La division del segundo al primero es " + div);
            Console.WriteLine("La division del primero al segundo es " + div1);
        }
    }
}
