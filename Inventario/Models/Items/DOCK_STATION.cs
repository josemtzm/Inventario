using System.ComponentModel.DataAnnotations;

namespace Inventario.Models
{
    public class DOCK_STATION : PERIFERICOS
    {
        public long Id { get; set; }
        [Display(Name = "No Serie Dock Station")]
        public string NO_SERIE { get; set; }
        [Display(Name = "Descripción Dock Station")]
        public string DESCRIPCION { get; set; }
    }
}