using System;

// Registro para guardar los datos del turno
class Turno
{
    public string nombre;
    public string cédula;
    public string fecha;
    public string hora;
}

// Clase que gestiona los turnos con un vector
class AgendaTurnos
{
    Turno[] turnos = new Turno[100]; // Creamos un vector de 100 turnos
    int contador = 0; // Para saber cuántos turnos se han ingresado

    // Método para agregar un nuevo turno
    public void AgendarTurno()
    {
        if (contador < turnos.Length)
        {
            Turno nuevo = new Turno();

            // Aquí dijimos con Carlos que pongamos entrada por consola para cada campo
            Console.Write("Ingrese nombre del paciente: ");
            nuevo.nombre = Console.ReadLine();

            Console.Write("Ingrese cédula: ");
            nuevo.cedula = Console.ReadLine();

            Console.Write("Ingrese fecha (dd/mm/aaaa): ");
            nuevo.fecha = Console.ReadLine();

            Console.Write("Ingrese hora (hh:mm): ");
            nuevo.hora = Console.ReadLine();

            turnos[contador] = nuevo; // Se guarda el turno en el vector
            contador++; // Se aumenta el contador

            Console.WriteLine("Turno registrado correctamente.\n");
        }
        else
        {
            Console.WriteLine("No hay espacio para más turnos.\n");
        }
    }

    // Método para mostrar todos los turnos agendados
    public void MostrarTurnos()
    {
        Console.WriteLine("\nTurnos registrados:");

        for (int i = 0; i < contador; i++)
        {
            Console.WriteLine("Paciente: " + turnos[i].nombre);
            Console.WriteLine("Cédula: " + turnos[i].cedula);
            Console.WriteLine("Fecha: " + turnos[i].fecha);
            Console.WriteLine("Hora: " + turnos[i].hora);
            Console.WriteLine("---------------------------");
        }

        if (contador == 0)
        {
            // Aquí María sugirió que avisemos si no hay turnos registrados
            Console.WriteLine("No hay turnos registrados.\n");
        }
    }
}

// Clase principal con el menú
class MainApp
{
    static void Main()
    {
        AgendaTurnos agenda = new AgendaTurnos();
        int opcion;

        // Menú principal del sistema
        do
        {
            Console.WriteLine("---- MENÚ ----");
            Console.WriteLine("1. Agendar nuevo turno");
            Console.WriteLine("2. Ver turnos agendados");
            Console.WriteLine("3. Salir");
            Console.Write("Seleccione una opción: ");

            string entrada = Console.ReadLine();
            int.TryParse(entrada, out opcion);
            Console.WriteLine();

            // Aquí dividimos las funciones con Andrés para probarlas por separado
            if (opcion == 1)
            {
                agenda.AgendarTurno();
            }
            else if (opcion == 2)
            {
                agenda.MostrarTurnos();
            }
            else if (opcion == 3)
            {
                Console.WriteLine("Saliendo del sistema...");
            }
            else
            {
                Console.WriteLine("Opción no válida.\n");
            }

        } while (opcion != 3);
    }
}