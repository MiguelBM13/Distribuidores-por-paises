using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Contracts;

namespace T2_Bovadilla_Miguel.Models
{
    public class Distribuidor
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El Nombre de Distribuidor es obligatorio")]
        public string NombreDistribuidor { get; set; }

        [Required(ErrorMessage = "El Nombre de la Razon Social es obligatorio")]
        public string RazonSocial { get; set; }

        [Required(ErrorMessage = "El Numero de Telefono es obligatorio")]
        [Phone]
        public string Telefono { get; set; }

        [Required(ErrorMessage = "El año de inicio de operación es obligatorio.")]
        [Range(1900, 3000, ErrorMessage = "El año de inicio de operación debe estar entre 1900 y 3000.")]
        public int AñoInicioOperacion { get; set; }

        [Required(ErrorMessage = "El Contacto de Distribuidor es obligatorio")]
        public string Contacto { get; set; }
    }
}