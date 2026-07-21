using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OrderService.Data;
using OrderService.Models;
using System.Net.Http.Json;

namespace OrderService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly OrderDbContext _context;
        private readonly IHttpClientFactory _httpClientFactory;

        public OrderController(
            OrderDbContext context,
            IHttpClientFactory httpClientFactory)
        {
            _context = context;
            _httpClientFactory = httpClientFactory;
        }

        [HttpGet]
        public async Task<IActionResult> GetOrders()
        {
            return Ok(await _context.Orders.ToListAsync());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetOrder(int id)
        {
            var order = await _context.Orders.FindAsync(id);

            if (order == null)
                return NotFound();

            return Ok(order);
        }

        [HttpPost]
        public async Task<IActionResult> AddOrder(Order order)
        {
            var client = _httpClientFactory.CreateClient();

            var product =
                await client.GetFromJsonAsync<ProductDto>(
                    $"http://localhost:5129/api/Product/{order.ProductId}");

            if (product == null)
                return BadRequest("Product does not exist.");

            order.TotalPrice = product.Price * order.Quantity;

            _context.Orders.Add(order);

            await _context.SaveChangesAsync();

            return Ok(order);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateOrder(int id, Order updatedOrder)
        {
            var order = await _context.Orders.FindAsync(id);

            if (order == null)
                return NotFound();

            order.ProductId = updatedOrder.ProductId;
            order.Quantity = updatedOrder.Quantity;
            order.TotalPrice = updatedOrder.TotalPrice;

            await _context.SaveChangesAsync();

            return Ok(order);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOrder(int id)
        {
            var order = await _context.Orders.FindAsync(id);

            if (order == null)
                return NotFound();

            _context.Orders.Remove(order);

            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}