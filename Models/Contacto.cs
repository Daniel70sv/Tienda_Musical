using System.ComponentModel.DataAnnotations;

namespace Tienda_De_Instrumentos_Musicales.Models
{
    public class Contacto
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "La categoria es requerido")]
        public int IdCategoria { get; set; }
        [Required(ErrorMessage = "El nombre es requerido")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "El Correo es requerido")]
        public string Correo { get; set; }
        [Required(ErrorMessage = "El Teléfono es requerido")]
        public int Telefono { get; set; }
        public Categoria Categoria { get; set; }
    }
}
