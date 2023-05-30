using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fin.Shared.Modelo
{
    public class Cliente
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Favor de escribir el nombre del cliente"), MaxLength(100)]
        public string? NombreCliente { get; set; }

        [Required(ErrorMessage = "Favor de escribir la dirección del cliente"), MaxLength(100)]
        public string? Direccion { get; set; }

        [Required(ErrorMessage = "Favor de escribir el número telefonico del cliente"), MaxLength(10)]
        public string? Telefono { get; set; }

        public virtual ICollection<Prestamos>? Prestamos { get; set; }
    }
}
