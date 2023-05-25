using Lab_6.Domain;
using Lab_6.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Lab_6.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private IOrderRepository _orderRepository;

        public OrderController(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        [HttpGet]
        public IReadOnlyCollection<Product> GatAll()
        {
            return _orderRepository.GetProducts();
        }

        [HttpPost]
        public IActionResult MakeOrder(string orderName, string productName, int quantity)
        {
            _orderRepository.AddOrder(orderName, productName, quantity);

            return Ok();
        }
    }
}
