using System;

class Program
{
    const int CAP = 75;

    static void Main()
    {
        string[] nombres = new string[CAP];
        char[] tipos = new char[CAP];       
        int[] niveles = new int[CAP];
        int[] estados = new int[CAP];     
        int[] investigadores = new int[CAP]; 

        int contador = 0;
        Random rnd = new Random();

        if (contador < CAP) { nombres[contador] = "Aquapuff"; tipos[contador] = 'A'; niveles[contador] = 10; estados[contador] = 0; investigadores[contador] = 0; contador++; }
        if (contador < CAP) { nombres[contador] = "Flamardo"; tipos[contador] = 'F'; niveles[contador] = 12; estados[contador] = 0; investigadores[contador] = 0; contador++; }
        if (contador < CAP) { nombres[contador] = "Leafin"; tipos[contador] = 'P'; niveles[contador] = 9; estados[contador] = 0; investigadores[contador] = 0; contador++; }

        while (true)
        {
            Console.Clear();
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Menú Principal - Centro de Investigación de Pochimons");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Pochimones Encontrados: " + contador + "/" + CAP);
            Console.WriteLine("");
            Console.WriteLine("1. Registrar Pochimon");
            Console.WriteLine("2. Asignar Investigador a Pochimon");
            Console.WriteLine("3. Actualizar Nivel de Pochimon");
            Console.WriteLine("4. Marcar Pochimon como Investigado");
            Console.WriteLine("5. Mostrar Información de Pochimons");
            Console.WriteLine("6. Buscar Pochimons por Tipo");
            Console.WriteLine("7. Mostrar Pochimons por Investigador");
            Console.WriteLine("8. Mostrar Pochimons Picados (nivel > 30)");
            Console.WriteLine("9. Salir");
            Console.WriteLine("--------------------------------------------------");
            Console.Write("Ingrese la opción deseada: ");

            string entrada = Console.ReadLine();
            int opcion;
            if (!int.TryParse(entrada, out opcion)) continue;

            Console.Clear();
            switch (opcion)
            {
                case 1:
                    if (contador >= CAP)
                    {
                        Console.WriteLine("La Pochidex está llena.");
                        Pausa();
                        break;
                    }
                    Console.Write("Ingrese el nombre del Pochimon: ");
                    string nombre = Console.ReadLine();
                    Console.Write("Ingrese el tipo del Pochimon (A/F/P): ");
                    char tipo;
                    char.TryParse(Console.ReadLine().ToUpper(), out tipo);
                    if (tipo != 'A' && tipo != 'F' && tipo != 'P')
                    {
                        Console.WriteLine("Tipo inválido. Use A, F o P.");
                        Pausa();
                        break;
                    }
                    Console.Write("Ingrese el nivel del Pochimon (entero >= 0): ");
                    int nivel;
                    if (!int.TryParse(Console.ReadLine(), out nivel) || nivel < 0) nivel = 0;

                    nombres[contador] = nombre;
                    tipos[contador] = tipo;
                    niveles[contador] = nivel;
                    estados[contador] = 0;
                    investigadores[contador] = 0;
                    contador++;
                    Console.WriteLine("Pochimon registrado.");
                    Pausa();
                    break;

                case 2:
                    Console.WriteLine("Pochimons no investigados:");
                    bool hayNoInvest = false;
                    for (int i = 0; i < contador; i++)
                    {
                        if (estados[i] == 0)
                        {
                            Console.WriteLine("Fila " + i + " - Nombre: " + nombres[i] + " Tipo: " + tipos[i] + " Nivel: " + niveles[i]);
                            hayNoInvest = true;
                        }
                    }
                    if (!hayNoInvest)
                    {
                        Console.WriteLine("No hay Pochimons con estado 0.");
                        Pausa();
                        break;
                    }
                    Console.Write("Ingrese el número de fila del Pochimon a asignar: ");
                    int filaAsign;
                    if (!int.TryParse(Console.ReadLine(), out filaAsign) || filaAsign < 0 || filaAsign >= contador || estados[filaAsign] != 0)
                    {
                        Console.WriteLine("Fila inválida o Pochimon no elegible.");
                        Pausa();
                        break;
                    }
                    Console.Write("Ingrese el código del Investigador (número): ");
                    int cod;
                    if (!int.TryParse(Console.ReadLine(), out cod) || cod < 0) cod = 0;
                    investigadores[filaAsign] = cod;
                    estados[filaAsign] = 1;
                    Console.WriteLine("Investigador asignado.");
                    Pausa();
                    break;

                case 3:
                    Console.WriteLine("Pochimons registrados:");
                    for (int i = 0; i < contador; i++)
                        Console.WriteLine("Fila " + i + " - Nombre: " + nombres[i] + " Nivel: " + niveles[i]);

                    Console.Write("Ingrese el número de fila del Pochimon a actualizar: ");
                    int filaAct;
                    if (!int.TryParse(Console.ReadLine(), out filaAct) || filaAct < 0 || filaAct >= contador)
                    {
                        Console.WriteLine("Fila inválida.");
                        Pausa();
                        break;
                    }
                    int incremento = rnd.Next(1, 4); 
                    niveles[filaAct] += incremento;
                    Console.WriteLine("Nivel incrementado en " + incremento + ". Nivel actual: " + niveles[filaAct]);
                    Pausa();
                    break;

                case 4:
                    Console.WriteLine("Pochimons en investigación:");
                    bool hayEnInvest = false;
                    for (int i = 0; i < contador; i++)
                    {
                        if (estados[i] == 1)
                        {
                            Console.WriteLine("Fila " + i + " - Nombre: " + nombres[i] + " Tipo: " + tipos[i] + " Nivel: " + niveles[i] + " Investigador: " + investigadores[i]);
                            hayEnInvest = true;
                        }
                    }
                    if (!hayEnInvest)
                    {
                        Console.WriteLine("No hay Pochimons en investigación.");
                        Pausa();
                        break;
                    }
                    Console.Write("Ingrese el número de fila del Pochimon a marcar como investigado: ");
                    int filaInv;
                    if (!int.TryParse(Console.ReadLine(), out filaInv) || filaInv < 0 || filaInv >= contador || estados[filaInv] != 1)
                    {
                        Console.WriteLine("Fila inválida o Pochimon no está en investigación.");
                        Pausa();
                        break;
                    }
                    estados[filaInv] = 2;
                    Console.WriteLine("Pochimon marcado como investigado.");
                    Pausa();
                    break;

                case 5:
                    Console.WriteLine("Todos los Pochimons:");
                    Console.WriteLine("Fila\tNombre\tTipo\tNivel\tEstado\tInvestigador");
                    for (int i = 0; i < contador; i++)
                    {
                        Console.WriteLine(i + "\t" + nombres[i] + "\t" + tipos[i] + "\t" + niveles[i] + "\t" + estados[i] + "\t" + investigadores[i]);
                    }
                    Pausa();
                    break;

                case 6:
                    Console.Write("Ingrese el tipo a buscar (A/F/P): ");
                    char busTipo;
                    char.TryParse(Console.ReadLine().ToUpper(), out busTipo);
                    Console.WriteLine("Resultados para tipo " + busTipo + ":");
                    bool alguno = false;
                    for (int i = 0; i < contador; i++)
                    {
                        if (tipos[i] == busTipo)
                        {
                            Console.WriteLine("Fila " + i + " - " + nombres[i] + " Nivel: " + niveles[i] + " Estado: " + estados[i]);
                            alguno = true;
                        }
                    }
                    if (!alguno) Console.WriteLine("No se encontraron Pochimons de ese tipo.");
                    Pausa();
                    break;

                case 7:
                    Console.Write("Ingrese el código del Investigador: ");
                    int codInv;
                    if (!int.TryParse(Console.ReadLine(), out codInv))
                    {
                        Console.WriteLine("Código inválido.");
                        Pausa();
                        break;
                    }
                    Console.WriteLine("Pochimons asignados al investigador " + codInv + ":");
                    bool alguno2 = false;
                    for (int i = 0; i < contador; i++)
                    {
                        if (investigadores[i] == codInv)
                        {
                            Console.WriteLine("Fila " + i + " - " + nombres[i] + " Tipo: " + tipos[i] + " Nivel: " + niveles[i] + " Estado: " + estados[i]);
                            alguno2 = true;
                        }
                    }
                    if (!alguno2) Console.WriteLine("No hay Pochimons asignados a ese investigador.");
                    Pausa();
                    break;

                case 8:
                    Console.WriteLine("Pochimons Picados (nivel > 30):");
                    bool hayPicados = false;
                    for (int i = 0; i < contador; i++)
                    {
                        if (niveles[i] > 30)
                        {
                            Console.WriteLine("Fila " + i + " - " + nombres[i] + " Tipo: " + tipos[i] + " Nivel: " + niveles[i]);
                            hayPicados = true;
                        }
                    }
                    if (!hayPicados) Console.WriteLine("No hay Pochimons con nivel > 30.");
                    Pausa();
                    break;

                case 9:
                    Console.WriteLine("Saliendo...");
                    return;

                default:
                    Console.WriteLine("Opción inválida.");
                    Pausa();
                    break;
            }
        }
    }

    static void Pausa()
    {
        Console.WriteLine("");
        Console.WriteLine("Presione ENTER para continuar...");
        Console.ReadLine();
    }
}