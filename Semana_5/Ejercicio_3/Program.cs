<<<<<<< HEAD
﻿using System; // Necesario para usar Console.WriteLine y Console.ReadLine
using System.Collections.Generic; // Necesario para usar List<T>

// Este programa calcula el producto escalar de dos vectores.
// Los vectores son (1, 2, 3) y (-1, 0, 2).

Console.WriteLine("Universidad Estatal Amazónica");
Console.WriteLine("------------------------------");
Console.WriteLine("Calculadora de Producto Escalar de Vectores");
Console.WriteLine("-------------------------------------------\n");

// 1. Almacenar el primer vector en una lista.
// Creamos una lista de números enteros para el Vector A.
List<int> vectorA = new List<int>();
vectorA.Add(1); // Añadimos el primer componente del vector A
vectorA.Add(2); // Añadimos el segundo componente del vector A
vectorA.Add(3); // Añadimos el tercer componente del vector A

Console.WriteLine("Vector A: (1, 2, 3)"); // Mostramos el Vector A en pantalla

// 2. Almacenar el segundo vector en una lista.
// Creamos una lista de números enteros para el Vector B.
List<int> vectorB = new List<int>();
vectorB.Add(-1); // Añadimos el primer componente del vector B
vectorB.Add(0);  // Añadimos el segundo componente del vector B
vectorB.Add(2);  // Añadimos el tercer componente del vector B

Console.WriteLine("Vector B: (-1, 0, 2)\n"); // Mostramos el Vector B en pantalla

// 3. Calcular el producto escalar.
// El producto escalar se calcula multiplicando los componentes correspondientes
// de cada vector y luego sumando esos resultados.
// Por ejemplo: (A.x * B.x) + (A.y * B.y) + (A.z * B.z)

int productoEscalar = 0; // Creamos una variable para guardar el resultado de la suma.
                         // La inicializamos en 0.

// Usamos un bucle 'for' para recorrer los elementos de ambos vectores.
// Asumimos que ambos vectores tienen la misma longitud.
// 'vectorA.Count' nos da el número de elementos en el Vector A.
for (int i = 0; i < vectorA.Count; i++)
{
    // Obtenemos el componente actual de cada vector.
    int componenteA = vectorA[i]; // Por ejemplo, en la primera vuelta, componenteA será 1.
    int componenteB = vectorB[i]; // Por ejemplo, en la primera vuelta, componenteB será -1.

    // Multiplicamos los componentes correspondientes.
    int productoComponentes = componenteA * componenteB; // 1 * -1 = -1

    // Sumamos este producto al total del producto escalar.
    productoEscalar = productoEscalar + productoComponentes; // productoEscalar = 0 + (-1) = -1
                                                             // En la siguiente vuelta: -1 + (2*0) = -1
                                                             // En la última vuelta: -1 + (3*2) = 5
}

// 4. Mostrar el resultado por pantalla.
Console.WriteLine($"El producto escalar de los vectores es: {productoEscalar}");

// Opcional: Mantener la consola abierta hasta que el usuario presione Enter.
Console.WriteLine("\nPresiona ENTER para salir.");
Console.ReadLine(); // Espera a que el usuario presione la tecla Enter.
=======
﻿using System; // Necesario para usar Console.WriteLine y Console.ReadLine
using System.Collections.Generic; // Necesario para usar List<T>

// Este programa calcula el producto escalar de dos vectores.
// Los vectores son (1, 2, 3) y (-1, 0, 2).

Console.WriteLine("Universidad Estatal Amazónica");
Console.WriteLine("------------------------------");
Console.WriteLine("Calculadora de Producto Escalar de Vectores");
Console.WriteLine("-------------------------------------------\n");

// 1. Almacenar el primer vector en una lista.
// Creamos una lista de números enteros para el Vector A.
List<int> vectorA = new List<int>();
vectorA.Add(1); // Añadimos el primer componente del vector A
vectorA.Add(2); // Añadimos el segundo componente del vector A
vectorA.Add(3); // Añadimos el tercer componente del vector A

Console.WriteLine("Vector A: (1, 2, 3)"); // Mostramos el Vector A en pantalla

// 2. Almacenar el segundo vector en una lista.
// Creamos una lista de números enteros para el Vector B.
List<int> vectorB = new List<int>();
vectorB.Add(-1); // Añadimos el primer componente del vector B
vectorB.Add(0);  // Añadimos el segundo componente del vector B
vectorB.Add(2);  // Añadimos el tercer componente del vector B

Console.WriteLine("Vector B: (-1, 0, 2)\n"); // Mostramos el Vector B en pantalla

// 3. Calcular el producto escalar.
// El producto escalar se calcula multiplicando los componentes correspondientes
// de cada vector y luego sumando esos resultados.
// Por ejemplo: (A.x * B.x) + (A.y * B.y) + (A.z * B.z)

int productoEscalar = 0; // Creamos una variable para guardar el resultado de la suma.
                         // La inicializamos en 0.

// Usamos un bucle 'for' para recorrer los elementos de ambos vectores.
// Asumimos que ambos vectores tienen la misma longitud.
// 'vectorA.Count' nos da el número de elementos en el Vector A.
for (int i = 0; i < vectorA.Count; i++)
{
    // Obtenemos el componente actual de cada vector.
    int componenteA = vectorA[i]; // Por ejemplo, en la primera vuelta, componenteA será 1.
    int componenteB = vectorB[i]; // Por ejemplo, en la primera vuelta, componenteB será -1.

    // Multiplicamos los componentes correspondientes.
    int productoComponentes = componenteA * componenteB; // 1 * -1 = -1

    // Sumamos este producto al total del producto escalar.
    productoEscalar = productoEscalar + productoComponentes; // productoEscalar = 0 + (-1) = -1
                                                             // En la siguiente vuelta: -1 + (2*0) = -1
                                                             // En la última vuelta: -1 + (3*2) = 5
}

// 4. Mostrar el resultado por pantalla.
Console.WriteLine($"El producto escalar de los vectores es: {productoEscalar}");

// Opcional: Mantener la consola abierta hasta que el usuario presione Enter.
Console.WriteLine("\nPresiona ENTER para salir.");
Console.ReadLine(); // Espera a que el usuario presione la tecla Enter.
>>>>>>> 916dc7e071af9511c1ff7afd3930be17863cad55
