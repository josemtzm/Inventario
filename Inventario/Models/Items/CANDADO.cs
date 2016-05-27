using System.ComponentModel.DataAnnotations;

namespace Inventario.Models
{
    public class CANDADO : PERIFERICOS
    {
        public long Id { get; set; }
        [Display(Name = "No Serie Candado")]
        public string NO_SERIE { get; set; }
        [Display(Name = "Descripción Candado")]
        public string DESCRIPCION { get; set; }
    }
}