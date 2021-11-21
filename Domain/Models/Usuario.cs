using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Usuario
    {
        public int Id{ get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string senha { get; set; }
        public Usuario()
        {}
        public Usuario(string nome,string email,string senha)
        {
            this.Nome = nome;
            this.Email = email;
            this.senha = senha;
        }
    }
}
