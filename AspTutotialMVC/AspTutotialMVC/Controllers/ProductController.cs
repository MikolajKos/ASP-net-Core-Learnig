using AspTutotialMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspTutotialMVC.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Product()
        {
            var product = new Product
            {
                Id = 1,
                Category = "Samochód",
                Description = "Super Samochód",
                Name = "BMW M5"
            };

            return View(product);
        }

        public IActionResult List()
        {
            var productList = new List<Product>
            {
                new Product
                {
                    Id = 1,
                    Category = "Samochód",
                    Description = "Super Samochód",
                    Name = "BMW M5"
                },
                new Product
                {
                    Id = 2,
                    Category = "Napoje",
                    Description = "Super Napój",
                    Name = "Coca Cola"
                },
                new Product
                {
                    Id = 3,
                    Category = "Roślina",
                    Description = "Super Roślina",
                    Name = "Storczyk"
                }
            };

            return View(productList);
        }
    }
}
