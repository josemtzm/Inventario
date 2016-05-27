using System;
using System.ComponentModel.DataAnnotations;

namespace Inventario.Models
{
    public class TIPO_EQUIPO
    {
        public long Id { get; set; }
        [Display(Name = "Tipo Equipo")]
        public string TipoEquipo { get; set; }
    }
}