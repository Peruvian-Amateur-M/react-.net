using System;
using System.Collections.Generic;

#nullable disable

namespace FinalHPII_PANOCCA_ROMERO_ANDRES.Models
{
    public partial class Especialidad
    {
        public Especialidad()
        {
            Alumnos = new HashSet<Alumno>();
        }

        public string Codesp { get; set; }
        public string Nomesp { get; set; }
        public int Costo { get; set; }
        public string Eliminado { get; set; }

        public virtual ICollection<Alumno> Alumnos { get; set; }
    }
}
