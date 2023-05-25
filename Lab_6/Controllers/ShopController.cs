using Lab_6.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Lab_6.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShopController : ControllerBase
    {
        private IShopRepository _shopRepository;

        public ShopController(IShopRepository shopRepository)
        {
            _shopRepository = shopRepository;
        }

        [HttpGet]
        public int GetPaydesk()
        {
            return _shopRepository.GetPaydesk();
        }

        [HttpPut]
        public IActionResult AddProduct(string productName, int quantity)
        {
            _shopRepository.BuyProduct(productName, quantity);
            return Ok();
        }
    }
}
