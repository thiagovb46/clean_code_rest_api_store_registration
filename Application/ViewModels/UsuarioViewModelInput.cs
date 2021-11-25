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
       [Required(ErrorMessage ="O campo Nome é obrigatório")]
       [MinLength(3,ErrorMessage ="O tamanho mínimo para o campo Nome é de 3 caracteres"), MaxLength(20,ErrorMessage = "O tamanho máximo para o campo Nome é de 20 caracteres")]
       public string Nome { get; set;}
       [Required(ErrorMessage = "O campo Email é obrigatório")]
       [EmailAddress]
       public string Email { get; set;}
       [Required(ErrorMessage ="O campo Senha é obrigatório")]
       [MinLength(8,ErrorMessage = "A senha deve ser de no mínimo 8 caracteres"), MaxLength(20, ErrorMessage = "A senha deve ser de no máximo 20 caracteres")]
       public string Senha { get; set;}
    }
}
