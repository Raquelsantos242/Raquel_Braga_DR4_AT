using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MeuMiniMuseu.Data.Models
{
    public class Pintura
    {
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        public string Artista { get; set; }

        [Required]
        public string Movimento { get; set; }

        [Required]
        public DateTime Created { get; set; }


        [Required]
        public String AnoCriacao { get; set; }



        [NotMapped]
        public IFormFile Upload { get; set; }

        public string ImageFile { get; set; }

        public string ImageFileName { get; set; }
    }
}
