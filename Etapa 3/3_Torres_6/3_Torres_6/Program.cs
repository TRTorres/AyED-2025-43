using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== MINI BALATRO (versión simplificada) ===\n");

        string[] mano = GenerarManoAleatoria();
        string tipo = TipoDeMano(mano);
        int basePts = PuntajeBase(mano);
        double mult = Multiplicador(tipo);
        double total = basePts * mult;

        // Pedimos al usuario si quiere activar los jokers (booleanos)
        bool jokerX2 = PreguntarBool("Activar Joker x2? (s/n): ");
        bool jokerMas10 = PreguntarBool("Activar Joker +10? (s/n): ");

        total = AplicarJokers(total, jokerX2, jokerMas10);
        MostrarResumen(mano, tipo, basePts, mult, total);
    }

    static bool PreguntarBool(string mensaje)
    {
        Console.Write(mensaje);
        string r = Console.ReadLine();
        if (string.IsNullOrEmpty(r)) return false;
        r = r.Trim().ToLower();
        return r == "s" || r == "y" || r == "true";
    }

    static string[] GenerarManoAleatoria()
    {
        string[] rangos = { "A", "K", "Q", "J", "T", "9", "8", "7", "6", "5", "4", "3", "2" };
        string[] palos = { "H", "D", "C", "S" };
        var rnd = new Random();
        string[] mano = new string[5];
        for (int i = 0; i < 5; i++)
        {
            string r = rangos[rnd.Next(rangos.Length)];
            string p = palos[rnd.Next(palos.Length)];
            mano[i] = r + p;
        }
        return mano;
    }

    static string TipoDeMano(string[] mano)
    {
        var counts = mano
            .Select(card => card.Substring(0, 1))
            .GroupBy(r => r)
            .Select(g => g.Count())
            .OrderByDescending(c => c)
            .ToArray();

        if (counts.Length > 0 && counts[0] == 4) return "Poker";
        if (counts.Length >= 2 && counts[0] == 3 && counts[1] == 2) return "Full";
        if (counts.Length > 0 && counts[0] == 3) return "Trio";
        if (counts.Any(c => c == 2)) return "Par";
        return "Nada";
    }

    static int PuntajeBase(string[] mano)
    {
        int ValorDeRango(string r)
        {
            switch (r)
            {
                case "A": return 14;
                case "K": return 13;
                case "Q": return 12;
                case "J": return 11;
                case "T": return 10;
                default:
                    return int.TryParse(r, out int v) ? v : 0;
            }
        }

        int sum = 0;
        foreach (var card in mano)
        {
            string rango = card.Substring(0, 1);
            sum += ValorDeRango(rango);
        }
        return sum;
    }

    static double Multiplicador(string tipo)
    {
        switch (tipo)
        {
            case "Nada": return 1.0;
            case "Par": return 1.5;
            case "Trio": return 2.5;
            case "Full": return 3.5;
            case "Poker": return 4.0;
            default: return 1.0;
        }
    }

    static double AplicarJokers(double puntaje, bool x2, bool mas10)
    {
        double resultado = puntaje;
        if (x2) resultado *= 2;
        if (mas10) resultado += 10;
        return resultado;
    }

    static void MostrarResumen(string[] mano, string tipo, int basePts, double mult, double total)
    {
        Console.Write("Mano: ");
        foreach (var c in mano) Console.Write("[" + c + "] ");
        Console.WriteLine();
        Console.WriteLine("Tipo: " + tipo);
        Console.WriteLine("Puntaje base: " + basePts);
        Console.WriteLine("Multiplicador: x" + mult);
        Console.WriteLine("Total (con Jokers): " + total);
    }
}