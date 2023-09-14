﻿using System;
using System.Collections.Generic;

#nullable disable

namespace FinalHPII_PANOCCA_ROMERO_ANDRES.Models
{
    public partial class Nota
    {
        public int Nroreg { get; set; }
        public DateTime? Fechareg { get; set; }
        public string Codalumno { get; set; }
        public string Codcurso { get; set; }
        public string Semestre { get; set; }
        public int? Ntrabajo { get; set; }
        public int? Nparcial { get; set; }
        public int? Nfinal { get; set; }
        public string Eliminado { get; set; }

        public virtual Alumno CodalumnoNavigation { get; set; }
        public virtual Curso CodcursoNavigation { get; set; }
    }
}
