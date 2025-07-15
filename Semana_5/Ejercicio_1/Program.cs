<<<<<<< HEAD
﻿using System; // Necesario para Console.WriteLine y Console.ReadKey
using System.Collections.Generic; // Necesario para usar List<T>

//Escribir un programa que almacene las asignaturas de un curso
// (por ejemplo Matemáticas, Física, Química, Historia y Lengua) 
//en una lista y la muestre por pantalla el mensaje Yo estoy estudiando <asignatura>, donde <asignatura> es cada una de las asignaturas de la lista.

Console.WriteLine("Universidad Estatal Amazónica");
Console.WriteLine("------------------------------");

// 1. Creando una lista para almacenamiento de las asignaturas
List<string> asignaturas = new List<string>();

// 2. Almacenando las asignaturas en la lista
asignaturas.Add("Estructura de Datos");
asignaturas.Add("Metodología de la Investigación");
asignaturas.Add("Cableado Estructurado");
asignaturas.Add("Sistemas Operativos");
asignaturas.Add("Ingles");

// 3. Recorrer la lista y mostrar el mensaje por pantalla
Console.WriteLine("Mis asignaturas del tercer semestre son:");
foreach (string asignatura in asignaturas)
{
    Console.WriteLine($"Yo estoy estudiando {asignatura}.");
}

// Opcional: Mantener la consola abierta hasta que el usuario presione una tecla
Console.WriteLine("\nPresiona cualquier tecla para salir.");
Console.ReadLine();

=======
﻿using System; // Necesario para Console.WriteLine y Console.ReadKey
using System.Collections.Generic; // Necesario para usar List<T>

//Escribir un programa que almacene las asignaturas de un curso
// (por ejemplo Matemáticas, Física, Química, Historia y Lengua) 
//en una lista y la muestre por pantalla el mensaje Yo estoy estudiando <asignatura>, donde <asignatura> es cada una de las asignaturas de la lista.

Console.WriteLine("Universidad Estatal Amazónica");
Console.WriteLine("------------------------------");

// 1. Creando una lista para almacenamiento de las asignaturas
List<string> asignaturas = new List<string>();

// 2. Almacenando las asignaturas en la lista
asignaturas.Add("Estructura de Datos");
asignaturas.Add("Metodología de la Investigación");
asignaturas.Add("Cableado Estructurado");
asignaturas.Add("Sistemas Operativos");
asignaturas.Add("Ingles");

// 3. Recorrer la lista y mostrar el mensaje por pantalla
Console.WriteLine("Mis asignaturas del tercer semestre son:");
foreach (string asignatura in asignaturas)
{
    Console.WriteLine($"Yo estoy estudiando {asignatura}.");
}

// Opcional: Mantener la consola abierta hasta que el usuario presione una tecla
Console.WriteLine("\nPresiona cualquier tecla para salir.");
Console.ReadLine();

>>>>>>> 916dc7e071af9511c1ff7afd3930be17863cad55
