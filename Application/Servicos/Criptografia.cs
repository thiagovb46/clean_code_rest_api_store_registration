using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Servicos
{
    public class Criptografia : ICriptografia
    {
        public string Hash(string senha)
        {
            return senha.GetHashCode().ToString(); 
        }
    }
}
