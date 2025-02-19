﻿using System.ComponentModel.DataAnnotations;

namespace MatriculasMVC.Models
{
    public class Estudiantes
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Apellido { get; set; }

        [Required]
        [MaxLength(50)]
        public string Nombre { get; set; }

        [Required]
        public DateTime FechaNacimiento { get; set; }

        public  List<Asistencia>? Asistencias { get; set; }
    }
}
