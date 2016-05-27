using System.ComponentModel.DataAnnotations;

namespace Inventario.Models
{
    public class MONITOR : PERIFERICOS
    {
        public long Id { get; set; }
        [Display(Name = "No Serie Monitor")]
        public string NO_SERIE { get; set; }
        [Display(Name = "Descripción Monitor")]
        public string DESCRIPCION { get; set; }
    }
}