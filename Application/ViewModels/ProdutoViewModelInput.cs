using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ViewModels
{
    public class ProdutoViewModelInput
    {
        [Required]
        [MinLength(3), MaxLength(80)]
        public string Nome { get;set; }
        [Required]
        [Range(0, 3000000000)]
        public float Preco { get; set; }
        public bool produtoEstaAtivo { get; set; }

    }
}
