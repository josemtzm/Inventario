using Inventario.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Inventario.ViewModels
{
    public class EquipoViewModel
    {
        public long ID { get; set; }
        [Display(Name = "No Serie")]
        public string SERIE { get; set; }
        [Display(Name = "Modelo")]
        public string MODELO { get; set; }
        public TIPO_EQUIPO TipoEquipo { get; set; }
        public MARCA_EQUIPO MarcaEquipo { get; set; }
    }
}
