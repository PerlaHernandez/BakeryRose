using System.ComponentModel.DataAnnotations;

namespace BakeryRose.Models
{
    public class Proveedores
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio.")]
        [StringLength(40, ErrorMessage = "El nombre no puede exceder 40 caracteres.")]
        [Display(Name = "Nombre del Proveedor")]
        public string Nombre { get; set; } = string.Empty;

        [Required(ErrorMessage = "La empresa es obligatoria.")]
        [StringLength(60)]
        [Display(Name = "Empresa")]
        public string Empresa { get; set; } = string.Empty;

        [Required(ErrorMessage = "El correo es obligatorio.")]
        [EmailAddress(ErrorMessage = "Correo no válido.")]
        [Display(Name = "Correo Electrónico")]
        public string Correo { get; set; } = string.Empty;

        [Required(ErrorMessage = "El número de contacto es obligatorio.")]
        [RegularExpression(@"^\d{10,}$", ErrorMessage = "Debe contener solo números y al menos 10 dígitos.")]
        [Display(Name = "Número de Contacto")]
        public string NumeroContacto { get; set; } = string.Empty;
    }
}
