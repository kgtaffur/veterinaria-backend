namespace veterinaria_backend.Models
{
    public partial class Paciente
    {
        public int id { get; set; }

        public string nombre { get; set; } = null!;

        public int edad { get; set; }

        public string specie { get; set; } = null!;

        public string raza { get; set; } = null!;

        public string color { get; set; } = null!;

        public string sexo { get; set; } = null!;

        public float peso { get; set; }

        public int historialMedicoId { get; set; }

        public virtual HistorialMedico historialMedico { get; set; }
    }
}
