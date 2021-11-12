using Domain.DomainsObjects.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Product
    {
        public int  Id { get; private set; }
        public int Ammount { get; private set; }
        public string Description { get; private set;}
        public float Price { get; private set; }
        public Dimensions Dimensions { get; private set;}
        public Product(int ammount,string description,float price, Dimensions dimensions)
        {
            this.Ammount = ammount;
            this.Description = description;
            this.Price = price;
            this.Dimensions = dimensions;
        }
    }
}
