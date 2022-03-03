using System;
using System.ComponentModel.DataAnnotations;

namespace Application.ViewModels
{
    public class ProductViewModelInput
    {
        [Required]
        [MinLength(3,ErrorMessage ="O tamanho mínimo para o campo nome é de 3 caracteres!"), MaxLength(80,ErrorMessage ="O Tamanho máximo para o campo Nome é de 80 caracteres")]
        public string Name { get;set; }
        [Required(ErrorMessage ="O campo preço é obrigatório")]
        [Range(0, 300000000,ErrorMessage = "Digite um valor entre 0 e 300.000.000,00 ")]
        public float Price { get; set; }
        [Required(ErrorMessage = "O campo produtoEstaAtivo é obrigatório!")]
        public bool IsActive { get; set; }

    }
}
