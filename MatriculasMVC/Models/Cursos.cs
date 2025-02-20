using System.ComponentModel.DataAnnotations;

namespace MatriculasMVC.Models
{
    public class Cursos
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Nombre { get; set; }

        [Required]
        [MaxLength(100)]
        public string Descripcion { get; set; }

        public List<Asistencia>? asistencias { get; set; }


    }
}
