using System.ComponentModel.DataAnnotations;

namespace MatriculasMVC.Models
{
    public class Asistencia
    {
        [Key]
        public int Id { get; set; }

        [Required]

        public DateTime FechaAsistecia { get; set; }

        [Required]
        [MaxLength(25)]
        public string estado { get; set; }

        public int? EstudianteId { get; set; }

        public Estudiantes? Estudiante { get; set; }

        public int? CursosId { get; set; }

        public Cursos? curso { get; set; }

    }
}
