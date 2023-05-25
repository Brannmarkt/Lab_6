namespace Lab_6.Domain
{
    public class Product
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }

        public Product() 
        { 

        }

        public Product(string name, int price)
        {
            Name = name;
            Price = price;
        }

        public Product(string name, int quantity, int price)
        {
            Name = name;
            Quantity = quantity;
            Price = price;
        }

        public Product(string id, string name, int price)
        {
            Id = id;
            Name = name;
            Price = price;
        }
    }
}
