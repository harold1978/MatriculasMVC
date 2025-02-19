using MatriculasMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace MatriculasMVC.Data
{
    public class AsistenciaDbContext:DbContext
    {
        public AsistenciaDbContext(DbContextOptions<AsistenciaDbContext> options):base(options)
        {
            
        }

        public DbSet<Estudiantes> Estudiante { get; set; }

        public DbSet<Cursos> Cursos { get; set; }

        public DbSet<Asistencia> Asistencias { get; set; }

    }
}
