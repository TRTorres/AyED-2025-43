using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Nivel 3 – Firewalls adyacentes (LITE)");
        int[,] g =
        {
            {0,1,0},
            {1,0,1},
            {0,1,0}
        };
        bool ok = Level3.CountAdjacent(g, 1, 1) == 4
               && Level3.CountAdjacent(g, 0, 0) == 2;
        Console.WriteLine(ok ? "✔ UNLOCK → Fragmento: -OK" : "🔒 LOCKED");
    }
}

static class Level3
{
    public static int CountAdjacent(int[,] grid, int row, int col)
    {
        if (grid == null) return 0;
        int rows = grid.GetLength(0);
        int cols = grid.GetLength(1);
        int count = 0;

        // arriba
        int r = row - 1, c = col;
        if (r >= 0 && r < rows && c >= 0 && c < cols && grid[r, c] == 1) count++;

        // abajo
        r = row + 1; c = col;
        if (r >= 0 && r < rows && c >= 0 && c < cols && grid[r, c] == 1) count++;

        // izquierda
        r = row; c = col - 1;
        if (r >= 0 && r < rows && c >= 0 && c < cols && grid[r, c] == 1) count++;

        // derecha
        r = row; c = col + 1;
        if (r >= 0 && r < rows && c >= 0 && c < cols && grid[r, c] == 1) count++;

        return count;
    }
}