using System.ComponentModel.DataAnnotations;

namespace PeliculasFede2023.Models
{
    public class Pelicula
    {
        public string Codigo { get; set; }
        [Required(ErrorMessage ="El nombre es requerido!")]
        public string Nombre { get; set; }
        [Range(1,300,ErrorMessage ="La duración debe estar comprendida entre {1} y {2}!")]
        [Display(Name ="Duración")]
        public int Duracion { get; set; }

        [Display(Name = "Categoría")]
        [Required(ErrorMessage ="La categoría es requerida!")]
        public string Categoria { get; set; }

        [Display(Name = "Reseña")]
        public string Resenia { get; set; }
    }
}
