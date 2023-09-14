﻿using System;
using System.Collections.Generic;

#nullable disable

namespace FinalHPII_PANOCCA_ROMERO_ANDRES.Models
{
    public partial class Curso
    {
        public Curso()
        {
            Nota = new HashSet<Nota>();
        }

        public string Codcurso { get; set; }
        public string Nomcurso { get; set; }
        public int? Nhoras { get; set; }
        public string Tipo { get; set; }
        public string Eliminado { get; set; }

        public virtual ICollection<Nota> Nota { get; set; }
    }
}
