using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.WriteLine("Nivel 4 – Cifrado +1 (LITE)");
        string msg = "ctOS";
        string enc = Level4.CaesarPlusOne(msg);
        bool ok = enc == "duPT"; // c->d, t->u, O->P, S->T
        Console.WriteLine(ok ? "✔ UNLOCK → Código final: CT-ACCESS-OK" : "🔒 LOCKED");
    }
}

static class Level4
{
    public static string CaesarPlusOne(string s)
    {
        if (s == null) return string.Empty;
        var sb = new StringBuilder(s.Length);
        foreach (char c in s)
        {
            if (char.IsLower(c))
            {
                char next = (char)('a' + (c - 'a' + 1) % 26);
                sb.Append(next);
            }
            else if (char.IsUpper(c))
            {
                char next = (char)('A' + (c - 'A' + 1) % 26);
                sb.Append(next);
            }
            else
            {
                sb.Append(c);
            }
        }
        return sb.ToString();
    }
}