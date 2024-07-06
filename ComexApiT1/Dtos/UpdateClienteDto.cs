using System.ComponentModel.DataAnnotations;

namespace ComexApiT1.Dtos
{
    public class UpdateClienteDto
    {
        [Required(ErrorMessage = "O Nome é obrigatório")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O Cpf é obrigatório")]
        public string Cpf { get; set; }

        [Required(ErrorMessage = "O Email é obrigatório")]
        public string Email { get; set; }

        [Required(ErrorMessage = "A Profissão é obrigatório")]
        public string Profissao { get; set; }

        [Required(ErrorMessage = "O Telefone é obrigatório")]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "O EndereçoId é obrigatório")]
        public int EnderecoId { get; set; }
    }
}
