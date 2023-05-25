using Microsoft.Extensions.Logging;
using System.Collections.ObjectModel;

namespace Lab_6.Domain
{
    public class Shop
    {
        public int Paydesk { get; set; }
        public ObservableCollection<Product> Products { get; set; }

        public Shop()
        {
            Paydesk = 100;
            Products = new ObservableCollection<Product>
            {
                new Product("Apple", 50, 10),
                new Product("Potato", 80, 8),
                new Product("Tomato", 40, 14),
                new Product("Carrot", 50, 12),
                new Product("Cucumber", 50, 10),
                new Product("Bread", 40, 15),
                new Product("Cabbage", 20, 18)
            };
        }

        public void BuyProductForCustomer(string name, int quantity)
        {
            Products.FirstOrDefault(x => x.Name == name).Quantity -= quantity;
        }

        public void BuyProductForShop(string name, int quantity)
        {
            Products.FirstOrDefault(x => x.Name == name).Quantity += quantity;
        }
    }
}
