using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ViewModels
{
    public class UsuarioViewModelInput
    {
       [Required]
       [MinLength(3), MaxLength(20)]
       public string Nome { get; set; }
       [Required]
       [EmailAddress]
       public string Email { get; set;}
       [Required]
       [MinLength(8), MaxLength(20)]
       public string Senha { get; set;}
    }
}
