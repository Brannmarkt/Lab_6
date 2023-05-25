using Lab_6.Domain;

namespace Lab_6.Repositories
{
    public interface IMainShopRepository
    {
        void BuyProductForShop(string productName, int quantity);
        void BuyProductForCustomer(string productName, int quantity);
        List<Product> GetAllProducts();
        int GetPaydesk();
        Product GetProduct(string productName);
    }

    public class MainShopRepository : IMainShopRepository
    {
        public Shop _shopManagement = new Shop();

        public void BuyProductForCustomer(string productName, int quantity)
        {
            _shopManagement.BuyProductForCustomer(productName, quantity);

            int price = GetProduct(productName).Price * quantity;
            _shopManagement.Paydesk += price;
        }

        public void BuyProductForShop(string productName, int quantity)
        {
            _shopManagement.BuyProductForShop(productName, quantity);

            int price = GetProduct(productName).Price * quantity;
            _shopManagement.Paydesk -= price;
        }

        public List<Product> GetAllProducts()
        {
            return _shopManagement.Products.ToList();
        }

        public int GetPaydesk()
        {
            return _shopManagement.Paydesk;
        }

        public Product GetProduct(string productName)
        {
            var product = _shopManagement.Products.FirstOrDefault(x => x.Name == productName);
            return product;
        }
    }
}
