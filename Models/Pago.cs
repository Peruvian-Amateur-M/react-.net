using System;
using System.Collections.Generic;

#nullable disable

namespace FinalHPII_PANOCCA_ROMERO_ANDRES.Models
{
    public partial class Pago
    {
        public int Codpago { get; set; }
        public string Codalumno { get; set; }
        public string Semestre { get; set; }
        public int Ncuota { get; set; }
        public int Monto { get; set; }
        public DateTime? Fecha { get; set; }
        public string Pagado { get; set; }
        public DateTime? FechaPago { get; set; }

        public virtual Alumno CodalumnoNavigation { get; set; }
    }
}
