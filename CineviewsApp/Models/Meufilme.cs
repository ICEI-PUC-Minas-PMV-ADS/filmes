﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CineviewsApp.Models
{
    [Table("MeusFilmes")]
    public class Meufilme
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="informar seu score")]
        [Display(Name = "Meu Score")]
        public int MeuScore { get; set; }

        [Display(Name = "Filme")]
        [Required(ErrorMessage = "informar o filme")]
        public int FilmeId { get; set; }

        [Display(Name = "Review")]
        public string Review { get; set; }

        [ForeignKey("FilmeId")]
        public Filme Filme { get; set; }

        public int ThumbsUp { get; set; }
        public int ThumbsDown { get; set; }
    }
}
