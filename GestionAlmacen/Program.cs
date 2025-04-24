using GestionAlmacen.Modelos;
using GestionAlmacen.Modelos.Enums;

namespace GestionAlmacen;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("======= Sistema de colección de videojuegos ========\n");

        InventarioJuegos inventario = new InventarioJuegos();
        CargarColeccionInicial(inventario);

        bool salir = false;

        while (!salir)
        {
            Console.WriteLine("\nMenú Principal:");
            Console.WriteLine("1. Mostrar colección de videojuegos");
            Console.WriteLine("2. Agregar videojuego a la colección");
            Console.WriteLine("3. Obtener videojuego por título");
            Console.WriteLine("0. Salir");

            Console.WriteLine("\n Seleccione una opcion: ");

            try
            {
                int opcion = int.Parse(Console.ReadLine());
                // Entra aqui -> 
                switch (opcion)
                {
                    case 1:
                        ObtenerVideojuegos(inventario);
                        break;
                    case 2:
                        AgregarVideojuego(inventario);
                        break;
                    case 3:
                        ObtenerVideojuegoPorTitulo(inventario);
                        break;
                    case 0:
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("Opcion invalida.");
                        break;
                }
            }
            catch (Exception ex) // throw an error
            {
                Console.WriteLine(ex.Message); // IndexOutOfRangeException // En internet
            }
        }
    }

    static void CargarColeccionInicial(InventarioJuegos inventario)
    {
        var videojuego1 = new Videojuego
        {
            Titulo = "Resident Evil",
            Descripcion = "Juego de zombies y disparos",
            Duracion = 6.5,
            Terminado = true,
            Genero = Genero.SHOOTER,
            FechaCreacion = DateTime.Now,
            FechaModificacion = DateTime.Now
        };

        var videojuego2 = new Videojuego
        {
            Titulo = "Forza Horizon 5",
            Descripcion = "Juego de simulación de carreras de automoviles",
            Duracion = 150,
            Terminado = false,
            Genero = Genero.CARRERAS,
            FechaCreacion = DateTime.Now,
            FechaModificacion = DateTime.Now
        };

        inventario.AgregarNuevoJuego(videojuego1);
        inventario.AgregarNuevoJuego(videojuego2);
    }

    static void ObtenerVideojuegos (InventarioJuegos inventario)
    {
        var videojuegos = inventario.ObtenerVideojuegos();

        if (videojuegos.Count == 0)
        {
            Console.WriteLine("No hay ningun videojuego en la colección");
            return;
        }

        Console.WriteLine("Colección de videojuegos");
        Console.WriteLine("ID\t\tTitulo\t\tGénero\t\tDescripcion\t\tDuración");
        Console.WriteLine("-------------------------------------");
        foreach (var videojuego in videojuegos)
        {
            Console.WriteLine($"{videojuego.Id}\t{videojuego.Titulo}\t{videojuego.Genero.ToString()}\t{videojuego.Descripcion}\t{videojuego.Duracion}");
        }
    }

    static void AgregarVideojuego(InventarioJuegos inventario)
    {
        Console.WriteLine("\nAgregar nuevo videojuego: ");

        Console.WriteLine("Titulo del videojuego: ");
        string titulo = Console.ReadLine();

        Console.WriteLine("Seleccionar el genero del videojuego (shooter 0, carrera 1, aventuras 2): ");
        if (!int.TryParse(Console.ReadLine(), out int genero) || genero < 0)
        {
            Console.WriteLine("Seleccion invalida.");
            return;
        }

        Console.WriteLine("Descripción del videojuego: ");
        string descripcion = Console.ReadLine();

        Console.WriteLine("Duración del videojuego: ");
        double duracion = Convert.ToDouble(Console.ReadLine());

        var videojuego = new Videojuego
        {
            Titulo = titulo,
            //Genero = genero,
            Descripcion = descripcion,
            Duracion = duracion
        };
    }
}
