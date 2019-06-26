using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroUniversitario.Entidades
{
 public class InscripcionDetalle
    {
        [Key]
        public int Id { get; set; }
        public int AsignaturaId { get; set; }
        public int EstudianteId { get; set; }

        //Faltan atributos

        public InscripcionDetalle()
        {
            Id = 0;
            AsignaturaId = 0;
            EstudianteId = 0;
        }
        public InscripcionDetalle(int Id, int AsignaturaId, int Estudiante)
        {
            this.Id = Id;
            this.AsignaturaId = AsignaturaId;
            this.EstudianteId = EstudianteId;
        }
    }
}
