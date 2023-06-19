namespace veterinaria_backend.Models
{
    public partial class FichaMedica
    {
        public int id { get; set; }

        public DateTime Registro { get; set; }

        public DateTime Actualizacion { get; set; }

        public string Color_mucosas { get; set; } = null!;

        public string Palpitacion_abdominal { get; set; } = null!;

        public string Genitales { get; set; } = null!;

        public float Temperatura { get; set; }

        public string Pulso_femoral { get; set; } = null!;

        public string Observaciones { get; set; } = null!;

        public int HistorialMedicoId { get; set; }

        public virtual HistorialMedico historialMedico { get; set; }
    }
}
