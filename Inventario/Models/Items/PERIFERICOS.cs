using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario.Models
{
    interface PERIFERICOS
    {
        long Id { get; set; }
        string NO_SERIE { get; set; }
        string DESCRIPCION { get; set; }
    }
}
