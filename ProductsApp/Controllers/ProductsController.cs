using ProductsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProductsApp.Controllers
{
    public class ProductsController : ApiController
    {
        private ProductRepository repo = ProductRepository.Current;
        public IEnumerable<Product> GetAllProducts()
        {
            return repo.GetAllProducts();
        } 
        public IHttpActionResult GetProduct(int id)
        {
            var prod = repo.GetProduct(id);
            if (prod == null)
            {
                return NotFound();
            }
            return Ok(prod);
        }
    }
}
