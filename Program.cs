C#
using System;

namespace AgendaClinica
{
    // Estructura 1: Registro (Struct) para agrupar datos del paciente
    public struct Paciente
    {
        public string Cedula;
        public string Nombre;
        public string Especialidad;
    }

    // Clase 1: Representa la entidad Turno
    public class Turno
    {
        public bool Ocupado { get; set; }
        public Paciente DatosPaciente { get; set; }

        public Turno()
        {
            Ocupado = false; // Por defecto el turno está libre
        }
    }

    // Clase 2: Gestor principal utilizando POO
    public class SistemaClinica
    {
        // Estructura 2: Matriz bidimensional para los horarios (5 días, 8 horas)
        private Turno[,] agendaSemanal;
        private string[] dias = { "Lunes", "Martes", "Miércoles", "Jueves", "Viernes" };

        public SistemaClinica()
        {
            agendaSemanal = new Turno[5, 8];
            InicializarAgenda();
        }

        private void InicializarAgenda()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    agendaSemanal[i, j] = new Turno();
                }
            }
        }

        public void RegistrarTurno()
        {
            Console.WriteLine("\n--- REGISTRAR TURNO ---");
            Console.Write("Ingrese Cédula: ");
            string ced = Console.ReadLine();
            Console.Write("Ingrese Nombre del Paciente: ");
            string nom = Console.ReadLine();
            Console.Write("Ingrese Especialidad Requerida: ");
            string esp = Console.ReadLine();

            Paciente nuevoPaciente = new Paciente { Cedula = ced, Nombre = nom, Especialidad = esp };

            Console.WriteLine("Días: 0(Lun), 1(Mar), 2(Mie), 3(Jue), 4(Vie)");
            Console.Write("Seleccione Día (0-4): ");
            int dia = int.Parse(Console.ReadLine());

            Console.WriteLine("Horas: 0(8am) a 7(3pm)");
            Console.Write("Seleccione Hora (0-7): ");
            int hora = int.Parse(Console.ReadLine());

            if (dia >= 0 && dia < 5 && hora >= 0 && hora < 8)
            {
                if (!agendaSemanal[dia, hora].Ocupado)
                {
                    agendaSemanal[dia, hora].DatosPaciente = nuevoPaciente;
                    agendaSemanal[dia, hora].Ocupado = true;
                    Console.WriteLine("Turno registrado con éxito.");
                }
                else
                {
                    Console.WriteLine("Error: La franja horaria ya está ocupada.");
                }
            }
            else
            {
                Console.WriteLine("Selección de día u hora fuera de rango.");
            }
        }

        public void ListarTurnos()
        {
            Console.WriteLine("\n--- AGENDA SEMANAL ---");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"\nDía: {dias[i]}");
                for (int j = 0; j < 8; j++)
                {
                    string estado = agendaSemanal[i, j].Ocupado ? $"Ocupado ({agendaSemanal[i, j].DatosPaciente.Nombre})" : "Libre";
                    Console.WriteLine($"  Hora {j + 8}:00 - {estado}");
                }
            }
        }

        public void BuscarPaciente()
        {
            Console.WriteLine("\n--- BUSCAR TURNO ---");
            Console.Write("Ingrese número de cédula: ");
            string cedulaBuscar = Console.ReadLine();
            bool encontrado = false;

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (agendaSemanal[i, j].Ocupado && agendaSemanal[i, j].DatosPaciente.Cedula == cedulaBuscar)
                    {
                        Console.WriteLine($"Paciente encontrado: {agendaSemanal[i, j].DatosPaciente.Nombre}");
                        Console.WriteLine($"Cita programada para el {dias[i]} a las {j + 8}:00 horas. Especialidad: {agendaSemanal[i, j].DatosPaciente.Especialidad}");
                        encontrado = true;
                    }
                }
            }

            if (!encontrado)
            {
                Console.WriteLine("No se encontraron turnos registrados para esa cédula.");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            SistemaClinica clinica = new SistemaClinica();
            int opcion;

            do
            {
                Console.WriteLine("\n=== SISTEMA DE TURNOS - CLÍNICA ===");
                Console.WriteLine("1. Registrar Turno");
                Console.WriteLine("2. Visualizar Agenda (Reportería)");
                Console.WriteLine("3. Buscar Cita de Paciente");
                Console.WriteLine("4. Salir");
                Console.Write("Seleccione una opción: ");
                
                if (int.TryParse(Console.ReadLine(), out opcion))
                {
                    switch (opcion)
                    {
                        case 1: clinica.RegistrarTurno(); break;
                        case 2: clinica.ListarTurnos(); break;
                        case 3: clinica.BuscarPaciente(); break;
                        case 4: Console.WriteLine("Saliendo del sistema..."); break;
                        default: Console.WriteLine("Opción no válida."); break;
                    }
                }
            } while (opcion != 4);
        }
    }
}