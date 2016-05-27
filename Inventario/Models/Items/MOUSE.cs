using System.ComponentModel.DataAnnotations;

namespace Inventario.Models
{
    public class MOUSE : PERIFERICOS
    {
        public long Id { get; set; }
        [Display(Name = "No Serie Mouse")]
        public string NO_SERIE { get; set; }
        [Display(Name = "Descripción Mouse")]
        public string DESCRIPCION { get; set; }
    }
}