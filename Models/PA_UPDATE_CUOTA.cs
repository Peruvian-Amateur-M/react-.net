using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalHPII_PANOCCA_ROMERO_ANDRES.Models
{
    public class PA_UPDATE_CUOTA
    {
        
        public string nomalumno { get; set; }

        [Key]
        public string codalumno { get; set; }

        public int ncuota { get; set; }

        public string pagado { get; set; }

    }
}
