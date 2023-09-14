using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalHPII_PANOCCA_ROMERO_ANDRES.Models
{
    public class PA_PAGOS_ALUMNO
    {

        [Key]
        public int codpago { get; set; }

        public int monto { get; set; }

        public string semestre { get; set; }

        public string nomalumno { get; set; }

        public string apealumno { get; set; }

        public string pagado { get; set; }

        public string fechapago { get; set; }

    }
}
