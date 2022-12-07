using System.ComponentModel.DataAnnotations;

namespace Tienda_De_Instrumentos_Musicales.Models
{
    public class Rol
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El nombre es requerido")]
        public string Nombre { get; set; }
    }
}
