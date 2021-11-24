using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Produto
    {
        public Produto() {}
        public int  Id { get; private set; }
        public string Nome{ get; private set; }
        public float Preco { get; private set;}
        public bool EstaAtivo { get; set;}
        public Produto(string nome, float preco, bool status)
        {
            this.Nome = nome;
            this.Preco = preco;
            this.EstaAtivo = status;
        }
    }
}
