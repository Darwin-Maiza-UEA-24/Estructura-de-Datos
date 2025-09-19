// Gestion de un catálogo de revistas de Ecuador, que permite al usuario buscar
// títulos específicos, muestra si el título fue encontrado o no.
// La búsqueda se realiza utilizando un método de búsqueda iterativa.
//***********************************************************************************************************************

using System;
using System.Collections.Generic;
using System.Linq;

// La clase principal del programa
public class CatalogoRevistas
{
    // Usamos una lista para almacenar los títulos de las revistas.
    // List<string> es una opción flexible y eficiente para esta tarea.
    private List<string> catalogoDeRevistas;

    // Constructor de la clase
    public CatalogoRevistas()
    {
        // Inicializamos la lista de revistas
        catalogoDeRevistas = new List<string>();
        // Llamamos al método para cargar los títulos al inicio del programa
        CargarRevistasEcuatorianas();
    }

    // Método para cargar al menos 10 títulos de revistas.
    private void CargarRevistasEcuatorianas()
    {
        Console.WriteLine("Cargando títulos de revistas ecuatorianas...");
        // Agregamos algunos títulos representativos para el catálogo.
        catalogoDeRevistas.Add("Vistazo");
        catalogoDeRevistas.Add("Cosmopolitan Ecuador");
        catalogoDeRevistas.Add("Gestión");
        catalogoDeRevistas.Add("Criterios de la Contabilidad y la Auditoría");
        catalogoDeRevistas.Add("Mundo Diners");
        catalogoDeRevistas.Add("El Agro");
        catalogoDeRevistas.Add("Revista de la PUCE");
        catalogoDeRevistas.Add("La Barra");
        catalogoDeRevistas.Add("El Telégrafo");
        catalogoDeRevistas.Add("Ekos");
        catalogoDeRevistas.Add("Línea Directa");
        Console.WriteLine("Catálogo cargado con éxito.");
    }

    // Método de búsqueda iterativa para encontrar un título en el catálogo.
    // Usa un bucle 'for' para recorrer cada elemento de la lista.
    public bool BuscarTituloIterativo(string tituloBuscado)
    {
        // El método ToLower() nos ayuda a hacer la búsqueda insensible a mayúsculas y minúsculas,
        // mejorando la experiencia del usuario.
        string tituloNormalizado = tituloBuscado.ToLower();

        // Iteramos sobre cada título en el catálogo
        foreach (string titulo in catalogoDeRevistas)
        {
            // Comparamos el título del catálogo con el título buscado.
            // Si encontramos una coincidencia, retornamos true inmediatamente.
            if (titulo.ToLower().Equals(tituloNormalizado))
            {
                return true; // El título fue encontrado
            }
        }
        // Si el bucle termina sin encontrar el título, retornamos false.
        return false; // El título no fue encontrado
    }

    // Método que gestiona la interacción con el usuario a través de un menú.
    public void Iniciar()
    {
        string opcion;
        bool continuar = true;

        while (continuar)
        {
            // Mostramos el menú de opciones al usuario
            Console.WriteLine("Universidad Estatal Amazonica");
            Console.WriteLine("\n--- Catálogo de Revistas Ecuatorianas ---");
            Console.WriteLine("1. Buscar revista por título");
            Console.WriteLine("2. Salir");
            Console.Write("Por favor, seleccione una opción: ");

            opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    Console.Write("\nIngrese el título de la revista a buscar: ");
                    string tituloABuscar = Console.ReadLine();

                    // Realizamos la búsqueda
                    bool encontrado = BuscarTituloIterativo(tituloABuscar);

                    // Mostramos el resultado de la búsqueda
                    if (encontrado)
                    {
                        Console.WriteLine($"\n✅ Encontrado: El título '{tituloABuscar}' Si, existe en el catálogo.");
                    }
                    else
                    {
                        Console.WriteLine($"\n❌ No encontrado: El título '{tituloABuscar}' no está en el catálogo el nombre de la revista.");
                    }
                    break;

                case "2":
                    continuar = false;
                    Console.WriteLine("\n¡Gracias por usar el buscador de Catálogo de Revistas!");
                    break;

                default:
                    Console.WriteLine("\nOpción no válida. Por favor, intente de nuevo.");
                    break;
            }
        }
    }
}

// La clase Program es el punto de entrada de la aplicación de consola.
class Program
{
    static void Main(string[] args)
    {
        // Creamos una instancia de la clase CatalogoRevistas
        CatalogoRevistas catalogo = new CatalogoRevistas();
        // Iniciamos el menú interactivo
        catalogo.Iniciar();
    }
}
