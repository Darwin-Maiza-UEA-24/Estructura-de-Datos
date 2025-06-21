// Nombres y Apellidos : DARWIN D. MAIZA Z.
// Fecha: 08 de junio de 2025

// Creando dos figuras como círculos y cuadrados. Con la POO,

using System; //Mostrar mensajes en la pantalla (Console.WriteLine)
              // y también para usar el número Pi (Math.PI) que es muy importante para los círculos.

namespace MisDibujosEnCodigo // Nombre de "caja de figuras" donde se guarda las clases.
{
    /// <summary>
    /// ¡molde para un Círculo!

    /// Un círculo solo necesita saber una cosa: su radio (lo que va del centro al borde).
    /// </summary>
    public class Circulo
    {
        // Esta es la "caja secreta" donde guardo el radio del círculo.
        // Pongo 'private' para que nadie cambie el radio directamente desde fuera.
        // 'double' es para números con decimales (como 3.5 o 10.25).
        private double elRadioDelCirculo;

        /// <summary>
        /// Cuando se crea un Círculo nuevo, necesito darle su radio inicial.
        /// Este es como el "manual de instrucciones" para hacer un Círculo.
        /// </summary>
        /// <param name="radioConElQueEmpieza">Aquí pongo el número del radio al crear el círculo.</param>
        public Circulo(double radioConElQueEmpieza)
        {
            // ¡Es importante que el radio sea un número positivo! Si no, el círculo no tiene sentido.
            if (radioConElQueEmpieza > 0)
            {
                elRadioDelCirculo = radioConElQueEmpieza; // Guardo el radio en mi cajita secreta.
            }
            else
            {
                // Al poner un radio malo (como -5 o 0), da un mensaje de error.
                throw new ArgumentException("El radio de un círculo debe ser un número positivo. ¡No puedo hacer un círculo así!");
            }
        }

        /// <summary>
        /// Si quiero saber cuál es el radio de mi círculo, uso este método.
        /// Es como preguntar "¿Cuál es tu radio?".
        /// </summary>
        /// <returns>Me devuelve el número del radio.</returns>
        public double DameElRadio()
        {
            return elRadioDelCirculo; // Le doy el valor que tengo guardado.
        }

        /// <summary>
        /// Si quiero cambiar el radio de mi círculo, uso este método.
        /// Es como decir "Cambia tu radio a este número".
        /// </summary>
        /// <param name="nuevoRadio">Este es el nuevo número para el radio. También debe ser positivo.</param>
        public void CambiaElRadio(double nuevoRadio)
        {
            // De nuevo, valido que el nuevo radio sea un número positivo.
            if (nuevoRadio > 0)
            {
                elRadioDelCirculo = nuevoRadio; // Actualizo el radio en mi cajita secreta.
            }
            else
            {
                throw new ArgumentException("El nuevo radio debe ser un número positivo. ¡No lo pude cambiar!");
            }
        }

        /// <summary>
        /// Este método calcula y me dice el Área del Círculo.
        /// El área es como el espacio que ocupa el círculo en el suelo.
        /// </summary>
        /// <returns>Me devuelve el número del área.</returns>
        public double CalcularMiArea()
        {
            // La fórmula mágica para el área es: Pi multiplicado por el radio, y el resultado otra vez por el radio.
            // Math.PI es el famoso número Pi (3.14159...).
            return Math.PI * elRadioDelCirculo * elRadioDelCirculo;
        }

        /// <summary>
        /// Este método calcula y me dice el Perímetro del Círculo.
        /// El perímetro es como la longitud de la línea que forma el borde del círculo.
        /// </summary>
        /// <returns>Me devuelve el número del perímetro.</returns>
        public double CalcularMiPerimetro()
        {
            // La fórmula mágica para el perímetro es: 2 multiplicado por Pi, y el resultado por el radio.
            return 2 * Math.PI * elRadioDelCirculo;
        }
    }

    /// <summary>
    /// ¡Ahora mi molde para un Cuadrado!
    /// Un cuadrado es más fácil, solo necesita saber cuánto mide un lado.
    /// Todos sus lados miden lo mismo.
    /// </summary>
    public class Cuadrado
    {
        // Esta es la cajita donde guardo la medida del lado del cuadrado.
        private double laMedidaDelLado;

        /// <summary>
        /// Para hacer un Cuadrado nuevo, le digo cuánto mide su lado.
        /// </summary>
        /// <param name="ladoConElQueEmpieza">Aquí va la medida del lado inicial.</param>
        public Cuadrado(double ladoConElQueEmpieza)
        {
            // También valido que el lado sea positivo. ¡Un lado de 0 o menos no tiene sentido!
            if (ladoConElQueEmpieza > 0)
            {
                laMedidaDelLado = ladoConElQueEmpieza; // Guardo la medida del lado.
            }
            else
            {
                throw new ArgumentException("El lado de un cuadrado debe ser un número positivo");
            }
        }

        /// <summary>
        /// Si quiero saber cuánto mide el lado de mi cuadrado, uso este método.
        /// </summary>
        /// <returns>Me devuelve la medida del lado.</returns>
        public double DameElLado()
        {
            return laMedidaDelLado;
        }

        /// <summary>
        /// Si quiero cambiar la medida del lado de mi cuadrado, uso este método.
        /// </summary>
        /// <param name="nuevoLado">La nueva medida para el lado.</param>
        public void CambiaElLado(double nuevoLado)
        {
            if (nuevoLado > 0)
            {
                laMedidaDelLado = nuevoLado;
            }
            else
            {
                throw new ArgumentException("¡Error! La nueva medida del lado debe ser un número positivo. No lo pude cambiar.");
            }
        }

        /// <summary>
        /// Este método calcula y me dice el Área del Cuadrado.
        /// </summary>
        /// <returns>Me devuelve el número del área.</returns>
        public double CalcularMiArea()
        {
            // La fórmula del área de un cuadrado es: lado multiplicado por lado.
            return laMedidaDelLado * laMedidaDelLado;
        }

        /// <summary>
        /// Este método calcula y me dice el Perímetro del Cuadrado.
        /// </summary>
        /// <returns>Me devuelve el número del perímetro.</returns>
        public double CalcularMiPerimetro()
        {
            // La fórmula del perímetro de un cuadrado es: 4 multiplicado por el lado.
            return 4 * laMedidaDelLado;
        }
    }

    /// <summary>
    /// Esta es la parte de mi programa que "arranca".
    /// Aquí es donde le digo al programa qué hacer con los Círculos y Cuadrados.
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("--- ¡show de Figuras Geométricas! ---");

            // --- ¡Empezamos con un Círculo! ---
            Console.WriteLine("\n=== Conozcan a mi amigo el Círculo ===");
            try // Esto es para "intentar" hacer algo y si sale mal, que no se rompa el programa.
            {
                // Creo un Círculo nuevo que llamo 'miCirculo' y le doy un radio de 5.0.
                Circulo miCirculo = new Circulo(5.0);

                Console.WriteLine($"Su radio es: {miCirculo.DameElRadio():F2}"); // Muestro su radio.
                Console.WriteLine($"Su área es: {miCirculo.CalcularMiArea():F2}"); // Le pido que calcule y muestre su área.
                Console.WriteLine($"Su perímetro es: {miCirculo.CalcularMiPerimetro():F2}"); // Y también su perímetro.

                // ¡Ahora voy a cambiarle el radio!
                miCirculo.CambiaElRadio(7.4);
                Console.WriteLine("\n--- ¡Guau! El Círculo creció ---");
                Console.WriteLine($"Ahora su nuevo radio es: {miCirculo.DameElRadio():F2}");
                Console.WriteLine($"Y su nueva área es: {miCirculo.CalcularMiArea():F2}");
                Console.WriteLine($"Y su nuevo perímetro es: {miCirculo.CalcularMiPerimetro():F2}");

                // Si quisiera probar un error 
                // Circulo = new Circulo(-1.0); // Esto intentaría crear un círculo con radio malo.
            }
            catch (ArgumentException ex) // Si algo sale mal en el "try", el error viene aquí.
            {
                Console.WriteLine($"¡Oh no! Hubo un problema con el Círculo: {ex.Message}");
            }

            // --- ¡Ahora le toca al Cuadrado! ---
            Console.WriteLine("\n=== Y ahora, ¡el Cuadrado! ===");
            try
            {
                // Creo un Cuadrado nuevo llamado 'miCuadrado' con un lado de 4.0.
                Cuadrado miCuadrado = new Cuadrado(4.0);

                Console.WriteLine($"Su lado mide: {miCuadrado.DameElLado():F2}"); // Muestro su lado.
                Console.WriteLine($"Su área es: {miCuadrado.CalcularMiArea():F2}"); // Le pido que calcule y muestre su área.
                Console.WriteLine($"Su perímetro es: {miCuadrado.CalcularMiPerimetro():F2}"); // Y su perímetro.

                // ¡Voy a cambiarle el lado también!
                miCuadrado.CambiaElLado(6.0);
                Console.WriteLine("\n--- El Cuadrado también se hizo más grande ---");
                Console.WriteLine($"Ahora su nuevo lado es: {miCuadrado.DameElLado():F2}");
                Console.WriteLine($"Y su nueva área es: {miCuadrado.CalcularMiArea():F2}");
                Console.WriteLine($"Y su nuevo perímetro es: {miCuadrado.CalcularMiPerimetro():F2}");

                // Si quisiera probar un error aquí (¡cuidado!):
                // Cuadrado cuadradoRaro = new Cuadrado(0); // Esto intentaría crear un cuadrado con lado cero.
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"¡Vaya! Hubo un problema con el Cuadrado: {ex.Message}");
            }

            Console.WriteLine("\n--- ¡Gracias por ver mi programa! :) ---");
            // Si la ventana se cierra muy rápido,
            // quita las "//" de la línea de abajo para que la ventana espere
            // a que presiones una tecla antes de desaparecer.
            // Console.ReadKey();
        }
    }
}