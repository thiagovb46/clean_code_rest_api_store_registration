using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DomainsObjects.ValueObjects
{
    public class Dimensions
    {
        public decimal HeightInCentimeters {get;private set; }
        public decimal WidthInCentimeters { get;private set; }
        public decimal DepthInCentimeters { get; set; }
        public Dimensions(decimal height,decimal  width,decimal depth)
        {
            Validations.ValidateIfSmallerThen(height, 0, "The value cannot be less than 0");
            Validations.ValidateIfSmallerThen(width, 0, "The value cannot be less than 0");
            Validations.ValidateIfSmallerThen(depth, 0, "The value cannot be less than 0");
            this.HeightInCentimeters = height;
            this.WidthInCentimeters = width;
            this.DepthInCentimeters = depth;
        }
    }
}
