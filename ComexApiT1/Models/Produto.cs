using System.ComponentModel.DataAnnotations;

namespace ComexApiT1.Models
{
    public class Produto
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O Nome é obrigatório")]
        [MaxLength(100, ErrorMessage = "O tamanho do campo Nome nao pode ser maior que 100 caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "A Descrição é obrigatório")]
        [MaxLength(500, ErrorMessage = "O tamanho do campo Descrição nao pode ser maior que 500 caracteres")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "O Preço é obrigatório")]
        public double PrecoUnitario { get; set; }

        [Required(ErrorMessage = "A Quantidade é obrigatório")]
        public int Quantidade { get; set; }
    }
}
