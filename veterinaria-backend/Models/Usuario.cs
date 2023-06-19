using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace veterinaria_backend.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        [Required]
        [Column(TypeName = "varchar(50)")]
        public string Nombre { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string Apellido { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string Email { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string ContraseñaHash { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string Direccion { get; set; }

        [Required]
        public string Telefono { get; set; }

        public int rolId { get; set; }
        public Rol rol { get; set; }
    }
}
