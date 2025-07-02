
// Las declaraciones 'using' siempre deben ir al principio del archivo.
using System; // Necesario para usar Console.WriteLine y Console.ReadLine
using System.Collections.Generic; // Necesario para usar List<T>

// Comentarios sobre el programa.
// Este programa almacena números del 1 al 10 en una lista
// y los muestra por pantalla en orden inverso, separados por comas.

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Universidad Estatal Amazónica");
        Console.WriteLine("------------------------------");

        // 1. Crear una lista para almacenar números enteros.
        // 'List<int>' indica que esta lista guardará solo números enteros.
        List<int> numeros = new List<int>();

        // 2. Almacenar los números del 1 al 10 en la lista.
        // Usamos un bucle 'for' para añadir los números de forma secuencial.
        for (int i = 1; i <= 10; i++)
        {
            numeros.Add(i); // El método 'Add()' añade el número 'i' a la lista.
        }

        // Mensaje informativo antes de mostrar el resultado.
        Console.WriteLine("Mostrando los números en orden inverso:");

        // 3. Recorrer la lista en orden inverso y mostrar los números separados por comas.
        // El bucle 'for' comienza desde el último elemento de la lista y va hacia el primero.
        // 'numeros.Count' devuelve la cantidad total de elementos en la lista.
        // Restamos 1 porque los índices de las listas comienzan en 0.
        for (int i = numeros.Count - 1; i >= 0; i--)
        {
            // 'numeros[i]' accede al elemento en la posición 'i' de la lista.
            Console.Write(numeros[i]); // Muestra el número sin un salto de línea.

            
            // Si 'i' es mayor que 0, significa que todavía quedan números por mostrar después de este.
            if (i > 0)
            {
                Console.Write(", "); // Añade una coma y un espacio.
            }
        }

        // Después de que el bucle termina, añadimos un salto de línea para que la consola se vea limpia.
        Console.WriteLine();

        // Opcional: Mantener la consola abierta hasta que el usuario presione Enter.
        Console.WriteLine("\nPresiona ENTER para salir.");
        Console.ReadLine(); // Espera a que el usuario presione Enter.
    }
}