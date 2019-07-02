using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroUniversitario.Entidades
{
 public class Inscripciones
    {
        [Key]

        public int InscripcionId { get; set; }
        public DateTime Fecha { get; set; }

        public decimal Monto { get; set; }
        public double Balance { get; set; }

        public virtual List<InscripcionDetalle> Detalles { get; set; }

        public Inscripciones()
        {
            InscripcionId = 0;
            Fecha = DateTime.Now;
            Monto = 0;
            Balance = 0;
        }

    }
}
