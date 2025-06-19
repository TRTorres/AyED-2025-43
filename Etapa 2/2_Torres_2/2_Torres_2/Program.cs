using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Torres_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int TPs, examenes, promtps, promexam;
            Console.WriteLine("Escriba la cantidad de TPs ");
            TPs = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escriba la cantidad de examenes ");
            examenes = Convert.ToInt32(Console.ReadLine());
            int[] tps = new int[TPs];
            int[] exams = new int[examenes];
            promtps = 0;
            promexam = 0;
            for (int i = 0; i < TPs; i++)
            {
                Console.WriteLine("Ingrese la nota del tp " + (i + 1));
                tps[i] = Convert.ToInt32(Console.ReadLine());
                promtps = promtps + tps[i];
            }
            for (int i = 0; i < examenes; i++)
            {
                Console.WriteLine("Ingrese la nota del examen " + (i + 1));
                exams[i] = Convert.ToInt32(Console.ReadLine());
                promexam = promexam + exams[i];
            }
            if (promexam / examenes >= 6 && promtps / TPs >= 6)
            {
                Console.WriteLine("El alumno puede aprobar la materia");
            }
        }
    }
}
