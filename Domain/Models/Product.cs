namespace Domain.Models
{
    public class Product
    {
        public Product() {}
        public int  Id { get; private set; }
        public string Name{ get; private set; }
        public float Price { get; private set;}
        public bool isActive { get; set;}
        public Product(string name, float price, bool status)
        {
            this.Name = name;
            this.Price = price;
            this.isActive = status;
        }
    }
}
