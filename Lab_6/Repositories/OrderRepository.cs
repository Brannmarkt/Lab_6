using Lab_6.Domain;

namespace Lab_6.Repositories
{
    public interface IOrderRepository
    {
        void AddOrder(string orderName, string productName, int quantity);
        List<Product> GetProducts();
        
    }

    public class OrderRepository : IOrderRepository
    {
        
        private IMainShopRepository _mainShopRepository;

        public OrderRepository(IMainShopRepository mainShopRepository)
        {
            _mainShopRepository = mainShopRepository;
        }

        public void AddOrder(string orderName, string productName, int quantity)
        {
            
            _mainShopRepository.BuyProductForCustomer(productName, quantity);

        }
        public List<Product> GetProducts()
        {
            return _mainShopRepository.GetAllProducts();
        }
    }
}
