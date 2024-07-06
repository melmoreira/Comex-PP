using System.ComponentModel.DataAnnotations;

namespace ComexApiT1.Dtos
{
    public class UpdateEnderecoDto
    {
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
    }
}
