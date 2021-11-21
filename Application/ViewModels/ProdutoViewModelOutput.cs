using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ViewModels
{
    public class ProdutoViewModelOutput
    {
        public string Nome { get; set; }
        public float Preco { get; set; }
        public string Status { get; set; }
        public int CodigoDoProduto { get; set; }
    }
}
