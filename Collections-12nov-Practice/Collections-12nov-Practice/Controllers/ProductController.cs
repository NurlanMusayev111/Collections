using Service.Services;
using Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections_12nov_Practice.Controllers
{
    public class ProductController
    {
        private readonly IProductService _productService;

        public ProductController()
        {
            _productService = new ProductService();
        }

        public void GetAll()
        {
            var result = _productService.GetAll();

            foreach (var item in result)
            {
                Console.WriteLine($"{item.Name} - {item.Price}");
            }
        }


        public void Search()
        {
            Console.WriteLine("Enter text :");
            string text = Console.ReadLine();

            var result = _productService.Search(text);

            foreach (var item in result)
            {
                Console.WriteLine($"{item.Name} - {item.Price}");
            }

        }
    }
}
