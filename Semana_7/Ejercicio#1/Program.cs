// Librerías necesarias del sistema
using System;
using System.Collections.Generic;

// Creación una clase llamada ParentesisBalanceados
class ParentesisBalanceados
{
    // El método verifica si una expresión tiene los paréntesis balanceados
    static bool EstaBalanceada(string expresion)
    {
        // Creamos una pila (estructura de datos tipo LIFO) para almacenar los símbolos abiertos
        Stack<char> pila = new Stack<char>();

        // Recorrido de cada carácter de la expresión ingresada
        foreach (char c in expresion)
        {
            // Si el carácter es un paréntesis, llave o corchete de apertura, lo agregamos a la pila
            if (c == '(' || c == '{' || c == '[')
            {
                pila.Push(c); // Agrega el símbolo a la cima de la pila
            }
            // Si el carácter es un símbolo de cierre
            else if (c == ')' || c == '}' || c == ']')
            {
                // Si la pila está vacía, no hay con qué emparejar este símbolo de cierre
                if (pila.Count == 0)
                    return false; // No está balanceado

                // Sacamos el último símbolo de apertura que fue guardado en la pila
                char ultimo = pila.Pop();

                // Comprobamos si el símbolo abierto coincide con el símbolo cerrado actual
                if ((c == ')' && ultimo != '(') ||
                    (c == '}' && ultimo != '{') ||
                    (c == ']' && ultimo != '['))
                {
                    return false; // No coinciden, por lo tanto no está balanceado
                }
            }
        }

        // Si al final la pila está vacía, todos los símbolos estaban balanceados
        return pila.Count == 0;
    }

    // Este es el método principal del programa, el que se ejecuta primero
    static void Main()
    {
        // Mostramos encabezado de la institución
        Console.WriteLine("Universidad Estatal Amazónica");
        Console.WriteLine("==============================");

        // Pedimos al usuario que ingrese una expresión matemática
        Console.WriteLine("Ingrese una expresión matemática:");
        string expresion = Console.ReadLine(); // Leemos la expresión

        // Usamos el método EstaBalanceada para comprobar si está bien formada
        if (EstaBalanceada(expresion))
            Console.WriteLine("Fórmula balanceada."); // Si todo está bien
        else
            Console.WriteLine("Fórmula no balanceada."); // Si hay errores de paréntesis
    }
}
