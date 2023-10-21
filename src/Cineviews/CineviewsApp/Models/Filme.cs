using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CineviewsApp.Models
{
    [Table("Filmes")]
    public class Filme
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Informar o filme")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Informar o diretor")]
        public string Diretor { get; set; }

        [Required(ErrorMessage = "Informar a data")]
        [Display(Name ="Data de Lançamento")]
        public int DataLancamento { get; set; }

        [Required(ErrorMessage = "Informar o score")]
        public int Score { get; set; }
    }
}
