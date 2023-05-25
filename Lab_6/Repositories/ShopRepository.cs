using Lab_6.Domain;

namespace Lab_6.Repositories
{
    public interface IShopRepository
    {
        void BuyProduct(string productName, int productQuantity);
        int GetPaydesk();
    }

    public class ShopRepository : IShopRepository
    {
        private IMainShopRepository _mainShopRepository;

        public ShopRepository(IMainShopRepository mainShopRepository)
        {
            _mainShopRepository = mainShopRepository;
        }

        public void BuyProduct(string productName, int productQuantity)
        {
            _mainShopRepository.BuyProductForShop(productName, productQuantity);
        }

        public int GetPaydesk()
        {
            return _mainShopRepository.GetPaydesk();
        }
    }
}
