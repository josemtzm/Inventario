using System.ComponentModel.DataAnnotations;

namespace Inventario.Models
{
    public class TECLADO : PERIFERICOS
    {
        public long Id { get; set; }
        [Display(Name = "No Serie Teclado")]
        public string NO_SERIE { get; set; }
        [Display(Name = "Descripción Teclado")]
        public string DESCRIPCION { get; set; }
    }
}