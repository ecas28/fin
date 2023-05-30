using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fin.Shared.Modelo
{
    public class Prestamos
    {
        public int Id { get; set; }

        public int ClienteId { get; set; }

        public virtual Cliente? Cliente { get; set; }

        public int LibroId { get; set; }

        public virtual Libro? Libro { get; set; }

        [Required(ErrorMessage = "Favor de escribir la fecha de inicio del prestamo")]
        public DateTime? Inicioprestamo { get; set; }

        [Required(ErrorMessage = "Favor de escribir la fecha de vencimiento del prestamo")]
        public DateTime? Vencimientoprestamo { get; set; }

        public DateTime? Fechadevolucion { get; set; }

    }
}
