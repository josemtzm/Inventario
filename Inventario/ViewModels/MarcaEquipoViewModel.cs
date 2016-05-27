using Microsoft.AspNet.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Inventario.ViewModels
{
    public class MarcaEquipoViewModel
    {
        [Display(Name = "Marca Equipo")]
        public long MarcaEquipoID { get; set; }
        public IEnumerable<SelectListItem> MarcasEquipo { get; set; }
    }
}
