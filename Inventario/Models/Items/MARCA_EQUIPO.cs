using System;
using System.ComponentModel.DataAnnotations;

namespace Inventario.Models
{
    public class MARCA_EQUIPO
    {
        public long Id { get; set; }
        [Display(Name = "Marca Equipo")]
        public string MarcaEquipo { get; set; }
    }
}