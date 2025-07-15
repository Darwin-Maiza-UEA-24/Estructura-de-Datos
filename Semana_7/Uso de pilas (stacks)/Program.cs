using System; // Necesario para usar Console.WriteLine
using System.Collections.Generic; // Necesario para usar Stack (la estructura de pila)

public class Program
{
    // ====================================================================
    // EJERCICIO: Resolución del problema de las Torres de Hanói utilizando pilas.
    // ====================================================================

    // Definimos tres pilas estáticas para representar las tres torres.
    // Cada entero en la pila representa un disco, donde el número más pequeño es un disco más pequeño.
    private static Stack<int> sourceTower;      // Torre de origen (donde empiezan los discos)
    private static Stack<int> auxiliaryTower;   // Torre auxiliar (para movimientos temporales)
    private static Stack<int> destinationTower; // Torre de destino (donde queremos mover los discos)
    private static int totalMoves = 0;          // Contador para saber cuántos movimientos se hicieron.

    // Esta función inicia la resolución de las Torres de Hanói para un número dado de discos.
    public static void SolveTowersOfHanoi(int numberOfDisks)
    {
        // Inicializamos las pilas para cada nueva ejecución.
        sourceTower = new Stack<int>();
        auxiliaryTower = new Stack<int>();
        destinationTower = new Stack<int>();
        totalMoves = 0; // Reiniciamos el contador de movimientos.

        // Colocamos los discos en la torre de origen.
        // Los discos se apilan del más grande (abajo) al más pequeño (arriba).
        for (int i = numberOfDisks; i >= 1; i--)
        {
            sourceTower.Push(i); // Añadimos el disco 'i' a la torre de origen.
        }

        Console.WriteLine($"\n--- Resolviendo Torres de Hanói con {numberOfDisks} discos ---");
        PrintTowers(); // Mostramos cómo están las torres al principio.

        // Llamamos a la función principal (recursiva) para resolver el problema.
        // Le pasamos el número de discos, la torre de origen, la de destino y la auxiliar.
        Hanoi(numberOfDisks, sourceTower, destinationTower, auxiliaryTower);

        Console.WriteLine($"\n--- Resolución Completada en {totalMoves} movimientos ---");
        PrintTowers(); // Mostramos el estado final de las torres.
    }

    // Esta es la función recursiva que resuelve las Torres de Hanói.
    // 'n': número de discos que vamos a mover en este paso.
    // 'source': la torre de donde tomamos los discos.
    // 'destination': la torre a donde queremos llevar los discos.
    // 'auxiliary': la torre que usamos como ayuda temporal.
    private static void Hanoi(int n, Stack<int> source, Stack<int> destination, Stack<int> auxiliary)
    {
        // CASO BASE: Si solo hay un disco para mover.
        // Simplemente lo movemos directamente de la torre de origen a la de destino.
        if (n == 1)
        {
            MoveDisk(source, destination);
        }
        // PASO RECURSIVO: Si hay más de un disco.
        else
        {
            // Paso 1: Mover los 'n-1' discos más pequeños de la torre de origen a la torre auxiliar.
            // Para esto, usamos la torre de destino como auxiliar temporal.
            Hanoi(n - 1, source, auxiliary, destination);

            // Paso 2: Mover el disco más grande (el disco 'n') de la torre de origen a la torre de destino.
            MoveDisk(source, destination);

            // Paso 3: Mover los 'n-1' discos que están en la torre auxiliar a la torre de destino.
            // Para esto, usamos la torre de origen (que ahora está vacía) como auxiliar temporal.
            Hanoi(n - 1, auxiliary, destination, source);
        }
    }

    // Esta función auxiliar realiza el movimiento de un solo disco entre dos torres.
    // También imprime el movimiento y el estado actual de las torres.
    private static void MoveDisk(Stack<int> source, Stack<int> destination)
    {
        // Sacamos el disco de la cima de la torre de origen.
        int disk = source.Pop();
        // Ponemos el disco en la cima de la torre de destino.
        destination.Push(disk);
        totalMoves++; // Aumentamos el contador de movimientos.

        Console.WriteLine($"Movimiento {totalMoves}: Mover disco {disk} de {GetTowerName(source)} a {GetTowerName(destination)}");
        PrintTowers(); // Mostramos el estado de las torres después de este movimiento.
    }

    // Esta función auxiliar devuelve el nombre de la torre para imprimirlo de forma amigable.
    private static string GetTowerName(Stack<int> tower)
    {
        if (tower == sourceTower) return "Origen";
        if (tower == auxiliaryTower) return "Auxiliar";
        if (tower == destinationTower) return "Destino";
        return "Desconocida"; // En caso de que se pase una pila no reconocida.
    }

    // Esta función auxiliar imprime el estado actual de todos los discos en cada torre.
    private static void PrintTowers()
    {
        Console.WriteLine("--------------------");
        // Convertimos la pila a un array para poder imprimir sus elementos.
        // 'ToArray()' invierte el orden, así que el primer elemento del array es el de la cima de la pila.
        Console.WriteLine("Torre Origen:    " + string.Join(", ", sourceTower.ToArray()));
        Console.WriteLine("Torre Auxiliar:  " + string.Join(", ", auxiliaryTower.ToArray()));
        Console.WriteLine("Torre Destino:   " + string.Join(", ", destinationTower.ToArray()));
        Console.WriteLine("--------------------");
    }


    // ====================================================================
    // MÉTODO PRINCIPAL (Main): Aquí es donde el programa comienza a ejecutarse.
    // ====================================================================
    public static void Main(string[] args)
    {
        // --- EJERCICIO: Resolución de las Torres de Hanói ---
        // Llamamos a la función para resolver las Torres de Hanói con 3 discos.
        // Puedes cambiar el número de discos aquí (ej. 4, 5, etc.) para ver cómo se resuelve.
        SolveTowersOfHanoi(3);

        // Opcional: Mantener la consola abierta hasta que el usuario presione Enter.
        Console.WriteLine("\nPresiona ENTER para salir.");
        Console.ReadLine(); // Espera a que el usuario presione Enter.
    }
}
