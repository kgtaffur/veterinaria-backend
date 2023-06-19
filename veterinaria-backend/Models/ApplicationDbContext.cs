using Microsoft.EntityFrameworkCore;

namespace veterinaria_backend.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) {
        }

        public DbSet<CitaMedica> CitaMedicas { get; set; }
        public DbSet<FichaMedica> FichaMedicas { get;set; }
        public DbSet<HistorialMedico> HistorialMedicas { get; set; }
        public DbSet<Medico> Medicos { get; set; }
        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Personal> Personal { get; set; }
        public DbSet<Propietario> Propietario { get; set;}
        public DbSet<Rol> Roles { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

    }
}
