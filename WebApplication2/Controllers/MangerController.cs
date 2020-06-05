using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MangerController : ControllerBase
    {
        [HttpPost]
        public void Post(string name, OrderType orderType)
        {
            var manager = JsonSerializer.Deserialize<Manager>(ControllerContext.HttpContext.Session.GetString("ManagerData"));
            manager.Orders.Add(new Order() { Name = name, Type = orderType });
            ControllerContext.HttpContext.Session.SetString("ManagerData", JsonSerializer.Serialize<Manager>(manager));
        }

        [HttpGet]
        public string GetCurrentOrders()
        {
            var manager = JsonSerializer.Deserialize<Manager>(ControllerContext.HttpContext.Session.GetString("ManagerData"));
            return JsonSerializer.Serialize<IEnumerable<Order>>(manager.Orders);
        }

        private class Manager
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public List<Order> Orders { get; set; }
        }

        private class Order
        {
            public string Name { get; set; }
            public OrderType Type { get; set; }
        }

        public enum OrderType
        {
            Import,
            Export
        }
    }
}