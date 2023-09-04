namespace Examen1DanielaHuezo
{
    internal class Program
    {
     
        static string[] codigos = new string[100];
        static string[] titulos = new string[100];
        static string[] isbns = new string[100];
        static string[] ediciones = new string[100];
        static string[] autores = new string[100];
        static int totalLibros = 0;

        static void Main()
        {
            bool salir = false;

            while (!salir)
            {
                Console.Clear();
                Console.WriteLine("Menú Principal");
                Console.WriteLine("1 - Ejercicio 1: Calcular costo de llamadas telefónicas internacionales");
                Console.WriteLine("2 - Ejercicio 2: Gestión de libros en una biblioteca");
                Console.WriteLine("3 - Salir");
                Console.Write("Seleccione una opción: ");

                int opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Ejercicio1();
                        break;
                    case 2:
                        Ejercicio2();
                        break;
                    case 3:
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            }
        }

        static void Ejercicio1()
        {
            while (true)
                {
                    Console.Clear();
                    Console.WriteLine("Calculadora de costo de llamadas telefónicas internacionales");
                    Console.WriteLine("Zonas disponibles:");
                    Console.WriteLine("12 - América del norte");
                    Console.WriteLine("15 - América central");
                    Console.WriteLine("18 - América del sur");
                    Console.WriteLine("19 - Europa");
                    Console.WriteLine("23 - Asia");
                    Console.WriteLine("---------------------------------------------------------");

                    Console.Write("Ingrese la clave de la zona: ");
                    int clave = int.Parse(Console.ReadLine());

                    Console.Write("Ingrese el número de minutos: ");
                    int minutos = int.Parse(Console.ReadLine());

                    double costo = CalcularCostoLlamada(clave, minutos);

                    Console.WriteLine($"El costo de la llamada es: {costo:C}");

                    Console.Write("¿Desea revisar otra zona? (S/N): ");
                    if (Console.ReadLine().ToUpper() != "S")
                        break;
                }
            }

            static double CalcularCostoLlamada(int clave, int minutos)
            {
                double costoPorMinuto = 0;

                switch (clave)
                {
                    case 12:
                        costoPorMinuto = 2;
                        break;
                    case 15:
                        costoPorMinuto = 2.2;
                        break;
                    case 18:
                        costoPorMinuto = 4.5;
                        break;
                    case 19:
                        costoPorMinuto = 3.5;
                        break;
                    case 23:
                        costoPorMinuto = 6;
                        break;
                    default:
                        Console.WriteLine("Clave de zona no válida.");
                        break;
                }

                return costoPorMinuto * minutos;
            }

        static void Ejercicio2()
            {
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("Gestión de libros en una biblioteca");
                    Console.WriteLine("1 - Agregar un libro");
                    Console.WriteLine("2 - Mostrar listado de libros");
                    Console.WriteLine("3 - Buscar libro por código");
                    Console.WriteLine("4 - Editar información de un libro por código");
                    Console.WriteLine("5 - Volver al menú principal");
                    Console.WriteLine("-----------------------------------");

                    Console.Write("Seleccione una opción: ");
                    int opcion = int.Parse(Console.ReadLine());

                    switch (opcion)
                    {
                        case 1:
                            AgregarLibro();
                            break;
                        case 2:
                            MostrarListadoDeLibros();
                            break;
                        case 3:
                            BuscarLibroPorCodigo();
                            break;
                        case 4:
                            EditarLibroPorCodigo();
                            break;
                        case 5:
                            return; // Vuelve al menú principal
                        default:
                            Console.WriteLine("Opción no válida.");
                            break;
                    }
                }
            }

            static void AgregarLibro()
            {
                Console.Write("Ingrese el código del libro: ");
                string codigo = Console.ReadLine();
                codigos[totalLibros] = codigo;

                Console.Write("Ingrese el título del libro: ");
                string titulo = Console.ReadLine();
                titulos[totalLibros] = titulo;

                Console.Write("Ingrese el ISBN del libro: ");
                string isbn = Console.ReadLine();
                isbns[totalLibros] = isbn;

                Console.Write("Ingrese la edición del libro: ");
                string edicion = Console.ReadLine();
                ediciones[totalLibros] = edicion;

                Console.Write("Ingrese el autor del libro: ");
                string autor = Console.ReadLine();
                autores[totalLibros] = autor;

                totalLibros++;
            }

            static void MostrarListadoDeLibros()
            {
                Console.WriteLine("Listado de libros");
                Console.WriteLine("-----------------");
                Console.WriteLine("| Código | Título                | ISBN        | Edición | Autor                |");
                Console.WriteLine("--------------------------------------------------------------------------");
                for (int i = 0; i < totalLibros; i++)
                {
                    Console.WriteLine($"| {codigos[i],6} | {titulos[i],20} | {isbns[i],11} | {ediciones[i],7} | {autores[i],20} |");
                }
                Console.WriteLine("--------------------------------------------------------------------------");
                Console.WriteLine();
            }

            static void BuscarLibroPorCodigo()
            {
                Console.Write("Ingrese el código del libro a buscar: ");
                string codigoBuscado = Console.ReadLine();

                for (int i = 0; i < totalLibros; i++)
                {
                    if (codigos[i] == codigoBuscado)
                    {
                        Console.WriteLine("Información del libro:");
                        Console.WriteLine($"Código: {codigos[i]}");
                        Console.WriteLine($"Título: {titulos[i]}");
                        Console.WriteLine($"ISBN: {isbns[i]}");
                        Console.WriteLine($"Edición: {ediciones[i]}");
                        Console.WriteLine($"Autor: {autores[i]}");
                    return;
                    }
                }
                        Console.WriteLine("libro no encontrado.");
            }

            static void EditarLibroPorCodigo()
            {
                Console.Write("Ingrese el código del libro a editar: ");
                string codigoEditar = Console.ReadLine();

                for (int i = 0; i < totalLibros; i++)
                {
                    if (codigos[i] == codigoEditar)
                    {
                        Console.Write("Ingrese el nuevo título del libro: ");
                        titulos[i] = Console.ReadLine();

                        Console.Write("Ingrese el nuevo ISBN del libro: ");
                        isbns[i] = Console.ReadLine();

                        Console.Write("Ingrese la nueva edición del libro: ");
                        ediciones[i] = Console.ReadLine();

                        Console.Write("Ingrese el nuevo autor del libro: ");
                        autores[i] = Console.ReadLine();

                        Console.WriteLine("Libro editado exitosamente.");
                        return;
                    }
                }

                    Console.WriteLine("Libro no encontrado.");
            }
    }
}

