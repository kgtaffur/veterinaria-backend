namespace veterinaria_backend.Models
{
    public partial class HistorialMedico
    {
        public int id { get; set; }

        public string vacunas_desparacitaciones { get; set; } = null!;

        public int paciente_mascota_id { get; set; }

        public virtual Paciente pacienteMascota { get; set; }

        public int propietario_id { get; set; }

        public virtual Propietario propietario { get; set; }
    }
}
