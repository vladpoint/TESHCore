using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TESHCore.Models
{
    public class Alumnos
    {
        public int Id { get; set; }
        public string NombreAlumno { get; set; }
        public string ApellidoAlumno { get; set; }
        public int CalificacionAlumno { get; set; }
        public DateTime FechaNacimientoAlumno { get; set;}
    }
}
