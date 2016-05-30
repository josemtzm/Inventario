using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario.Models
{
    public class Equipo
    {
        [Key]
        public long ID { get; set; }
        [Display(Name = "No Serie")]
        public string SERIE { get; set; }
        [Display(Name = "Modelo")]
        public string MODELO { get; set; }
        [ForeignKey("TipoEquipoId")]
        public virtual TIPO_EQUIPO TipoEquipo { get; set; }
        [ForeignKey("MarcaEquipoId")]
        public virtual MARCA_EQUIPO MarcaEquipo { get; set; }
        [Display(Name = "Procesador")]
        public string PROCESADOR { get; set; }
        [Display(Name = "Memoria")]
        public string MEMORIA { get; set; }
        [Display(Name = "Disco Duro")]
        public string DISCO_DURO { get; set; }
        [Display(Name = "MAC Ethernet")]
        public string MAC_ETH { get; set; }
        [Display(Name = "MAC Wifi")]
        public string MAC_WIFI { get; set; }
        public TECLADO Teclado { get; set; }
        public MOUSE Mouse { get; set; }
        public MONITOR Monitor { get; set; }
        public DOCK_STATION DockStation { get; set; }
        public CANDADO Candado { get; set; }
    }
}
