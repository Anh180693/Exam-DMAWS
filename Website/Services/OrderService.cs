using Website.Models;

namespace Website.Services
{
    public class OrderService
    {
        private readonly HttpClient _httpClient;

        public OrderService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<Order> CreateOrderAsync(Order order)
        {
            var response = await _httpClient.PostAsJsonAsync("order", order);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<Order>();
        }

        public async Task EditOrderAsync(int itemCode, Order order)
        {
            var response = await _httpClient.PutAsJsonAsync($"order/{itemCode}", order);
            response.EnsureSuccessStatusCode();
        }
    }
}
