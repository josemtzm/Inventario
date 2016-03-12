using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario.Models
{
    class Asignaciones
    {
        public Usuario USUARIO_ID { get; set; }
        public Equipo NO_SERIE { get; set; }
        public bool ASIGNADO { get; set; }
        public DateTime FECHA_ALTA { get; set; }
        public DateTime FECHA_BAJA { get; set; }
    }
}
