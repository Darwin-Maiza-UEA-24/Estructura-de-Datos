//Programa que da marcha a la agenda de la clínica
System.Console.WriteLine("Universidad Estatal Amazónica");
System.Console.WriteLine("=============================");
System.Console.WriteLine();

AgendaTurnos agenda = new AgendaTurnos(10);

//Crear pacientes y turnos
Paciente paciente1 = new Paciente("1708402449", "Rodrigo", 58);
Paciente paciente2 = new Paciente("1201524856", "Rosa", 25);
Paciente paciente3 = new Paciente("2300048952", "Madelyn", 28);

agenda.AgendarTurno(paciente1, 0);
agenda.AgendarTurno(paciente2, 1);
agenda.AgendarTurno(paciente3, 2);

//Imprimir agenda
agenda.ImprimirTurnos();

//Búsqueda por Cédula
System.Console.WriteLine();
agenda.BuscarCedula("2300048952");