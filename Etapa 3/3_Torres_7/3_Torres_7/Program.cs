using System;

class Character
{
    public string Nombre;
    public string Saga;
    public int Fuerza;
    public int Defensa;
    public bool EsHeroe;
}

class Program
{
    const int MAX = 20;
    static Character[] lista = new Character[MAX];
    static int count = 0;

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n--- Borderlands MVM ---");
            Console.WriteLine("1. Nuevo personaje");
            Console.WriteLine("2. Consultar por nombre");
            Console.WriteLine("3. Modificar personaje");
            Console.WriteLine("4. Eliminar personaje");
            Console.WriteLine("5. Mostrar todos");
            Console.WriteLine("6. Salir");
            Console.Write("Opción: ");
            string opt = Console.ReadLine();

            if (opt == "1") CrearPersonaje();
            else if (opt == "2") ConsultarPersonaje();
            else if (opt == "3") ModificarPersonaje();
            else if (opt == "4") EliminarPersonaje();
            else if (opt == "5") MostrarTodos();
            else if (opt == "6") break;
            else Console.WriteLine("Opción inválida.");
        }
    }

    static void CrearPersonaje()
    {
        if (count >= MAX)
        {
            Console.WriteLine("Máximo de personajes alcanzado.");
            return;
        }

        Console.Write("Nombre: ");
        string nombre = Console.ReadLine()?.Trim();
        if (string.IsNullOrEmpty(nombre))
        {
            Console.WriteLine("Nombre inválido.");
            return;
        }

        if (FindIndexByName(nombre) != -1)
        {
            Console.WriteLine("Ya existe un personaje con ese nombre.");
            return;
        }

        Console.Write("Saga/Facción: ");
        string saga = Console.ReadLine()?.Trim() ?? "";

        int fuerza = ReadInt("Fuerza (entero): ");
        int defensa = ReadInt("Defensa (entero): ");
        bool esHeroe = ReadBool("Es héroe? (s/n): ");

        var p = new Character { Nombre = nombre, Saga = saga, Fuerza = fuerza, Defensa = defensa, EsHeroe = esHeroe };
        lista[count++] = p;
        Console.WriteLine("Personaje creado correctamente.");
    }

    static void ConsultarPersonaje()
    {
        Console.Write("Nombre a consultar: ");
        string nombre = Console.ReadLine()?.Trim();
        int idx = FindIndexByName(nombre);
        if (idx == -1) Console.WriteLine("Personaje no encontrado.");
        else PrintCharacter(lista[idx]);
    }

    static void ModificarPersonaje()
    {
        Console.Write("Nombre del personaje a modificar: ");
        string nombre = Console.ReadLine()?.Trim();
        int idx = FindIndexByName(nombre);
        if (idx == -1)
        {
            Console.WriteLine("Personaje no encontrado.");
            return;
        }

        int nuevaFuerza = ReadInt("Nueva fuerza: ");
        int nuevaDefensa = ReadInt("Nueva defensa: ");
        bool esHeroe = ReadBool("Es héroe? (s/n): ");

        lista[idx].Fuerza = nuevaFuerza;
        lista[idx].Defensa = nuevaDefensa;
        lista[idx].EsHeroe = esHeroe;
        Console.WriteLine("Personaje modificado.");
    }

    static void EliminarPersonaje()
    {
        Console.Write("Nombre del personaje a eliminar: ");
        string nombre = Console.ReadLine()?.Trim();
        int idx = FindIndexByName(nombre);
        if (idx == -1)
        {
            Console.WriteLine("Personaje no encontrado.");
            return;
        }

        // mover elementos hacia la izquierda para llenar el hueco
        for (int i = idx; i < count - 1; i++) lista[i] = lista[i + 1];
        lista[count - 1] = null;
        count--;
        Console.WriteLine("Personaje eliminado.");
    }

    static void MostrarTodos()
    {
        if (count == 0)
        {
            Console.WriteLine("No hay personajes.");
            return;
        }

        // crear arreglo temporal de nombres para ordenar
        string[] nombres = new string[count];
        for (int i = 0; i < count; i++) nombres[i] = lista[i].Nombre;
        Array.Sort(nombres, StringComparer.CurrentCultureIgnoreCase);

        Console.WriteLine("\nLista de personajes (ordenada):");
        foreach (var n in nombres)
        {
            int idx = FindIndexByName(n); // búsqueda por nombre para obtener el objeto
            if (idx != -1) PrintCharacter(lista[idx]);
        }
    }

    // helpers
    static int FindIndexByName(string nombre)
    {
        if (string.IsNullOrEmpty(nombre)) return -1;
        for (int i = 0; i < count; i++)
            if (string.Equals(lista[i].Nombre, nombre, StringComparison.CurrentCultureIgnoreCase))
                return i;
        return -1;
    }

    static void PrintCharacter(Character p)
    {
        Console.WriteLine("------");
        Console.WriteLine("Nombre: " + p.Nombre);
        Console.WriteLine("Saga: " + p.Saga);
        Console.WriteLine("Fuerza: " + p.Fuerza);
        Console.WriteLine("Defensa: " + p.Defensa);
        Console.WriteLine("Es héroe: " + (p.EsHeroe ? "Sí" : "No"));
    }

    static int ReadInt(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            string s = Console.ReadLine();
            if (int.TryParse(s, out int v)) return v;
            Console.WriteLine("Entrada inválida. Ingrese un entero.");
        }
    }

    static bool ReadBool(string prompt)
    {
        Console.Write(prompt);
        string s = Console.ReadLine()?.Trim().ToLower() ?? "";
        return s == "s" || s == "y" || s == "true";
    }
}