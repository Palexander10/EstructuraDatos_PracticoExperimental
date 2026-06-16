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