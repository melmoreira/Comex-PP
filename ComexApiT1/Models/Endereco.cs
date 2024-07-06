using System.ComponentModel.DataAnnotations;

namespace ComexApiT1.Models
{
    public class Endereco
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O Bairro é obrigatório")]
        public string Bairro { get; set; }

        [Required(ErrorMessage = "A Cidade é obrigatório")]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "O Complemento é obrigatório")]
        public string Complemento { get; set; }

        [Required(ErrorMessage = "O Estado é obrigatório")]
        public string Estado { get; set; }

        [Required(ErrorMessage = "A Rua é obrigatório")]
        public string Rua { get; set; }

        [Required(ErrorMessage = "O Numero é obrigatório")]
        public int Numero { get; set; }

        // Mapeamento EF
        public virtual Cliente Cliente { get; set; }
    }
}
