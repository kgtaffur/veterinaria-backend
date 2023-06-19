namespace veterinaria_backend.Models
{
    public partial class Propietario
    {
        public int id { get; set; }

        public string nombre { get; set; } = null!;

        public string apellido { get; set; } = null!;

        public string direccion { get; set; } = null!;

        public string telefono { get; set; } = null!;

        public string email { get; set; } = null!;

        public int historialMedicoId { get; set; }

        public virtual HistorialMedico historialMedico { get; set; }
    }
}
