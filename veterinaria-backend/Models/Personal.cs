using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace veterinaria_backend.Models
{
    public class Personal
    {
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string Cargo { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string Horario { get; set; }

        public int usuarioId { get; set; }
        public Usuario usuario { get; set; }
    }
}
