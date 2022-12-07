using System.ComponentModel.DataAnnotations;

namespace Tienda_De_Instrumentos_Musicales.Models
{
    public class Categoria
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El nombre es requerido")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "La clasificación es requerida")]
        public string Clasificacion { get; set; }
        [Required(ErrorMessage = "La Descripción es requerida")]
        public string Descripcion { get; set; }
    }
}
