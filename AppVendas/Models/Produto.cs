using System.ComponentModel.DataAnnotations;

namespace AppVendas.Models
{
    public class Produto
    {
        public Guid ProdutoId { get; set; }

        [Display(Name = "Descrição")]
        [Required(ErrorMessage = "O campo não pode ser vazio!")]
        [MaxLength(100, ErrorMessage = "O campo deve ter, no maximo, 100 caracteres!")]
        [MinLength(3, ErrorMessage = "O campo deve ter, no minimo, 3 caracteres!")]
        public string ProdutoNome { get; set; }

        [Required(ErrorMessage = "O campo não pode ser vazio!")]
        [Range(0, double.MaxValue, ErrorMessage = "O valor do produto deve ser um número positivo")]
        public double Valor { get; set; }

        [Display(Name = "Estoque Atual")]
        [Required(ErrorMessage = "O campo não pode ser vazio!")]
        [Range(0, double.MaxValue, ErrorMessage = "A quantidade em Estoque deve ser positivo")]
        public double QtadeEstoque { get; set; }
        [Display(Name = "Ativo?")]
        public bool? CadastroAtivo { get; set; } = true;

        //chave estrangeira como fazer referencia outra tabela
        [Required(ErrorMessage = "Por favor selecione uma Categoria!")]
        [Display(Name = "Categoria")]
        public Guid CategoriaId { get; set; }
        public Categoria? Categoria { get; set; }

    }
}
