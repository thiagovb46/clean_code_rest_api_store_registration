using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ViewModels
{
    public class ProductViewModel
    {
        public int Ammount { get; private set; }
        public string Description { get; private set; }
        public float Price { get; private set; }
        public decimal HeightInCentimeters { get; private set; }
        public decimal WidthInCentimeters { get; private set; }
        public decimal DepthInCentimeters { get; set; }
    }
}
