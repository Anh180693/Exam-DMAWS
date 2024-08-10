using Microsoft.AspNetCore.Mvc;
using Website.Services;
using Website.Models;

namespace Website.Controllers
{
    public class OrderController : Controller
    {
        private readonly OrderService _orderService;

        public OrderController(OrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Order order)
        {
            if (ModelState.IsValid)
            {
                await _orderService.CreateOrderAsync(order);
                return RedirectToAction("Success");
            }

            return View(order);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.ItemCode = id;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, Order order)
        {
            if (ModelState.IsValid)
            {
                await _orderService.EditOrderAsync(id, order);
                return RedirectToAction("Success");
            }

            return View(order);
        }

        [HttpGet]
        public IActionResult Success()
        {
            return View();
        }
    }
}
