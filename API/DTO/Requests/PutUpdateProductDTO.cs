using System.ComponentModel.DataAnnotations;

namespace API.DTO.Requests
{
    public class PutUpdateProductDTO
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "O Nome do Produto é Obrigatório!!")]
        [StringLength(50), MinLength(3)]
        public string Name { get; set; }

        [Required(ErrorMessage = "O Codigo do Produto é Obrigatório!!")]
        [RegularExpression("^\\d{13}$", ErrorMessage = "Código do Produto Invalido. Insira um Código valido para Cadastro!!")]
        public string Ean { get; set; }

        [Required(ErrorMessage = "A Quantidade do Produto é Obrigatória!!")]
        [Range(1, 99999, ErrorMessage = "Quantidade Minima 1 e Maxima 99999 para Cadastro do Produto!!")]
        public int Amount { get; set; }

        [Required(ErrorMessage = "Data de Validade do Produto é Obrigatória!!")]
        public DateOnly Validate { get; set; }
    }
}
