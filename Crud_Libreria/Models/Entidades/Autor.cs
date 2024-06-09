using System.ComponentModel.DataAnnotations;

namespace Crud_Libreria.Models.Entidades
{
    public class Autor
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="El {0} es requisito obligatorio")]
        public string Nombre { get; set; }

        [DisplayFormat(DataFormatString ="{0:yyyy/MM/dd hh:mm tt}")]
        public DateTime FechaNacimiento { get; set; }
    }
}
