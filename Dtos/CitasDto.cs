using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace amoliaz.Dtos
{
    internal class CitasDto
    {
        string dni = "aaaaaa";
        string nombre = "aaaaa";
        string apellidos = "aaaa";
        string especialidad = "aaaaaa";
        DateTime fechaCita = new DateTime(9999, 12, 31);
        bool asistencia = false;

        public CitasDto() { }

        public CitasDto(string dni, string nombre, string apellidos, string especialidad, DateTime fechaCita, bool asistencia)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.especialidad = especialidad;
            this.fechaCita = fechaCita;
            this.asistencia = asistencia;
        }

        public string Dni { get => dni; set => dni = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Especialidad { get => especialidad; set => especialidad = value; }
        public DateTime FechaCita { get => fechaCita; set => fechaCita = value; }
        public bool Asistencia { get => asistencia; set => asistencia = value; }
    }
}
