using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fin.Shared.Modelo
{
    public class Libro
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Favor de escribir el nombre del libro"), MaxLength(100)]
        public string? Nombrelibro { get; set; }

        [Required(ErrorMessage = "Favor de escribir el nombre del autor"), MaxLength(100)]
        public string? Autorlibro { get; set; }

        [Required(ErrorMessage = "Favor de escribir la fecha de publicación del libro"), MaxLength(10)]
        public string? Fechapublicacion { get; set; }

        public virtual ICollection<Prestamos>? Prestamos { get; set; }
    }
}
