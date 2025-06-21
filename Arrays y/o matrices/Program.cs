// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic; // Necesario para usar List<T>
using System.Linq; // Necesario para métodos como .FirstOrDefault()

// Definición de la clase Estudiante
// Esta clase representa la estructura de datos para cada estudiante.
public class Estudiante
{
    // Propiedades del estudiante
    public int Id { get; set; }
    public string Nombres { get; set; }
    public string Apellidos { get; set; }
    public string Direccion { get; set; }
    
    // Array para almacenar exactamente 3 teléfonos.
    // Los arrays se usan cuando el número de elementos es fijo y conocido.
    public string[] Telefonos { get; set; }

    // Constructor de la clase Estudiante
    // Permite crear una nueva instancia de Estudiante con todos sus datos.
    public Estudiante(int id, string nombres, string apellidos, string direccion, string[] telefonos)
    {
        Id = id;
        Nombres = nombres;
        Apellidos = apellidos;
        Direccion = direccion;
        
        // Asignamos el array de teléfonos.
        // Nos aseguramos de que siempre haya espacio para 3, incluso si se pasan menos.
        if (telefonos != null && telefonos.Length == 3)
        {
            Telefonos = telefonos;
        }
        else
        {
            // Si no se proporcionan 3 teléfonos, inicializamos un array vacío o con valores por defecto.
            // Para este ejemplo, si no son exactamente 3, creamos uno de 3 con vacíos.
            Telefonos = new string[3]; 
            if (telefonos != null)
            {
                for (int i = 0; i < Math.Min(telefonos.Length, 3); i++)
                {
                    Telefonos[i] = telefonos[i];
                }
            }
        }
    }

    // Método para mostrar la información del estudiante
    public void MostrarInformacion()
    {
        Console.WriteLine($"-----------------------------------");
        Console.WriteLine($"ID: {Id}");
        Console.WriteLine($"Nombres: {Nombres}");
        Console.WriteLine($"Apellidos: {Apellidos}");
        Console.WriteLine($"Dirección: {Direccion}");
        Console.Write("Teléfonos: ");
        
        // Iteramos sobre el array de teléfonos para mostrarlos
        for (int i = 0; i < Telefonos.Length; i++)
        {
            Console.Write($"{Telefonos[i]}");
            if (i < Telefonos.Length - 1)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine();
        Console.WriteLine($"-----------------------------------");
    }
}

// Clase principal del programa
public class Program
{
    // List para almacenar todos los objetos Estudiante.
    // List<T> es una colección dinámica, ideal cuando no se sabe el número exacto de elementos.
    private static List<Estudiante> listaEstudiantes = new List<Estudiante>();
    private static int proximoId = 1; // Para asignar IDs automáticamente

    public static void Main(string[] args)
    {
        Console.WriteLine("Bienvenido al Sistema de Gestión de Estudiantes");
        Console.WriteLine("---------------------------------------------");

        bool salir = false;
        while (!salir)
        {
            MostrarMenu();
            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    RegistrarEstudiante();
                    break;
                case "2":
                    MostrarTodosLosEstudiantes();
                    break;
                case "3":
                    BuscarEstudiantePorId();
                    break;
                case "4":
                    salir = true;
                    Console.WriteLine("Saliendo del sistema. ¡Hasta luego!");
                    break;
                default:
                    Console.WriteLine("Opción no válida. Intente de nuevo.");
                    break;
            }
            Console.WriteLine("\nPresione cualquier tecla para continuar...");
            Console.ReadKey();
            Console.Clear(); // Limpia la consola para el siguiente menú
        }
    }

    // Método para mostrar las opciones del menú
    private static void MostrarMenu()
    {
        Console.WriteLine("\nMenú:");
        Console.WriteLine("1. Registrar nuevo estudiante");
        Console.WriteLine("2. Mostrar todos los estudiantes");
        Console.WriteLine("3. Buscar estudiante por ID");
        Console.WriteLine("4. Salir");
        Console.Write("Seleccione una opción: ");
    }

    // Método para registrar un nuevo estudiante
    private static void RegistrarEstudiante()
    {
        Console.WriteLine("\n--- Registrar Nuevo Estudiante ---");

        int id = proximoId++; // Asigna el próximo ID disponible
        Console.Write("Nombres: ");
        string nombres = Console.ReadLine();
        Console.Write("Apellidos: ");
        string apellidos = Console.ReadLine();
        Console.Write("Dirección: ");
        string direccion = Console.ReadLine();

        string[] telefonos = new string[3]; // Creamos un array de 3 strings para los teléfonos
        for (int i = 0; i < 3; i++)
        {
            Console.Write($"Teléfono {i + 1}: ");
            telefonos[i] = Console.ReadLine();
        }

        // Creamos una nueva instancia de Estudiante
        Estudiante nuevoEstudiante = new Estudiante(id, nombres, apellidos, direccion, telefonos);
        
        // Añadimos el nuevo estudiante a la lista
        listaEstudiantes.Add(nuevoEstudiante);

        Console.WriteLine("\n¡Estudiante registrado exitosamente!");
    }

    // Método para mostrar todos los estudiantes registrados
    private static void MostrarTodosLosEstudiantes()
    {
        Console.WriteLine("\n--- Lista de Estudiantes Registrados ---");
        if (listaEstudiantes.Count == 0)
        {
            Console.WriteLine("No hay estudiantes registrados aún.");
            return;
        }

        // Iteramos sobre la lista de estudiantes y llamamos al método MostrarInformacion de cada uno
        foreach (Estudiante estudiante in listaEstudiantes)
        {
            estudiante.MostrarInformacion();
        }
    }

    // Método para buscar un estudiante por su ID
    private static void BuscarEstudiantePorId()
    {
        Console.WriteLine("\n--- Buscar Estudiante por ID ---");
        Console.Write("Ingrese el ID del estudiante a buscar: ");
        
        if (int.TryParse(Console.ReadLine(), out int idBuscado))
        {
            // Usamos LINQ para encontrar el estudiante.
            // .FirstOrDefault() devuelve el primer elemento que coincide, o null si no encuentra ninguno.
            Estudiante estudianteEncontrado = listaEstudiantes.FirstOrDefault(e => e.Id == idBuscado);

            if (estudianteEncontrado != null)
            {
                Console.WriteLine("\nEstudiante encontrado:");
                estudianteEncontrado.MostrarInformacion();
            }
            else
            {
                Console.WriteLine($"No se encontró ningún estudiante con el ID {idBuscado}.");
            }
        }
        else
        {
            Console.WriteLine("ID inválido. Por favor, ingrese un número.");
        }
    }
}

