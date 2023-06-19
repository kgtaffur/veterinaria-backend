using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace veterinaria_backend.Models
{
    public class Medico
    {
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string Especialidad { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string Experiencia { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string Educacion { get; set; }

        public int usuarioId { get; set; }
        public Usuario usuario { get; set; }
    }
}
