using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DomainsObjects
{
    public static class Validations
    {
        public static void ValidateIfSmallerThen(decimal value,decimal minValue,string message)
        {
            if (value < minValue) 
                throw new DomainException(message);
        }
    }
}
