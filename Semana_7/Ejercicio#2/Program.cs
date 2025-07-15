using System;
using System.Collections.Generic;

public class Program
{
    // Pilas para representar las torres
    private static Stack<int> sourceTower;
    private static Stack<int> auxiliaryTower;
    private static Stack<int> destinationTower;

    // Diccionario para asociar pilas con nombres
    private static Dictionary<Stack<int>, string> towerNames;

    private static int totalMoves = 0;

    public static void SolveTowersOfHanoi(int numberOfDisks)
    {
        sourceTower = new Stack<int>();
        auxiliaryTower = new Stack<int>();
        destinationTower = new Stack<int>();
        totalMoves = 0;

        // Agregamos los discos a la torre de origen
        for (int i = numberOfDisks; i >= 1; i--)
        {
            sourceTower.Push(i);
        }

        // Asociamos las pilas con nombres legibles
        towerNames = new Dictionary<Stack<int>, string>
        {
            { sourceTower, "Origen" },
            { auxiliaryTower, "Auxiliar" },
            { destinationTower, "Destino" }
        };

        Console.WriteLine($"\n--- Resolviendo Torres de Hanói con {numberOfDisks} discos ---");
        PrintTowers();

        // Resolución recursiva
        Hanoi(numberOfDisks, sourceTower, destinationTower, auxiliaryTower);

        Console.WriteLine($"\n--- Resolución Completada en {totalMoves} movimientos ---");
        PrintTowers();
    }

    private static void Hanoi(int n, Stack<int> source, Stack<int> destination, Stack<int> auxiliary)
    {
        if (n == 1)
        {
            MoveDisk(source, destination);
        }
        else
        {
            Hanoi(n - 1, source, auxiliary, destination);
            MoveDisk(source, destination);
            Hanoi(n - 1, auxiliary, destination, source);
        }
    }

    private static void MoveDisk(Stack<int> source, Stack<int> destination)
    {
        int disk = source.Pop();
        destination.Push(disk);
        totalMoves++;

        Console.WriteLine($"Movimiento {totalMoves}: Mover disco {disk} de {GetTowerName(source)} a {GetTowerName(destination)}");
        PrintTowers();
    }

    private static string GetTowerName(Stack<int> tower)
    {
        return towerNames.ContainsKey(tower) ? towerNames[tower] : "Desconocida";
    }

    private static void PrintTowers()
    {
        Console.WriteLine("--------------------");
        Console.WriteLine("Torre Origen:    " + string.Join(", ", sourceTower.ToArray()));
        Console.WriteLine("Torre Auxiliar:  " + string.Join(", ", auxiliaryTower.ToArray()));
        Console.WriteLine("Torre Destino:   " + string.Join(", ", destinationTower.ToArray()));
        Console.WriteLine("--------------------");
    }

    // Método principal requerido para ejecutar el programa
    public static void Main(string[] args)
    {
        // Puedes cambiar el número de discos aquí (por ejemplo, 3, 4, 5...)
        SolveTowersOfHanoi(3);

        Console.WriteLine("\nPresiona ENTER para salir...");
        Console.ReadLine();
    }
}

