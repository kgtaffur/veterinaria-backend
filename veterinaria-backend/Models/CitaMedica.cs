namespace veterinaria_backend.Models
{
    public partial class CitaMedica
    {
        public int id { get; set; }

        public DateTime horaCita { get; set; }

        public string consultorio { get; set; } = null!;

        public int HistorialMedicoId { get; set; }

        public virtual HistorialMedico historialMedico { get; set; }
    }
}
