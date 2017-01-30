using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using SpecialityDrinks.Models;
using SpecialityDrinks.DAL.NewSpecialityDrinkDBTableAdapters;
using System.Data;

namespace SpecialityDrinks.Controllers.Api
{
    public class ProductsController : ApiController
    {

        private readonly ProductsTableAdapter _context;

        public ProductsController()
        {
            _context = new ProductsTableAdapter();
        }

        public IHttpActionResult GetProducts(string query = null)
        {
            

            DataTable dt = _context.GetAllProducts();
            var products = Products(dt);



            if (!string.IsNullOrWhiteSpace(query))
            {
                products = products.Where(c => c.Name.Contains(query, StringComparison.OrdinalIgnoreCase));
            }
            return Ok(products);
        }

        [HttpPut]
        public IHttpActionResult UpdateProduct(int id, Product product)
        {

            _context.UpdateProduct(
                product.Name,
                product.Brand,
                product.Size,
                product.Strength,
                product.Price,
                product.Created,
                DateTime.Now,
                id

                );
            return Ok();

        }

        [HttpDelete]
        public IHttpActionResult DeleteProduct(int id)
        {

            _context.DeleteProduct(id);
            return Ok();

        }
       

        private static IEnumerable<Product> Products(DataTable dt)
        {
            IEnumerable<Product> products = (from DataRow row in dt.Rows
                select new Product
                {
                    Id = int.Parse(row["ProductID"].ToString()),
                    Name = row["Name"].ToString(),
                    Brand = row["Brand"].ToString(),
                    Size = double.Parse(row["Size"].ToString()),
                    Strength = double.Parse(row["Strength"].ToString()),
                    Price = decimal.Parse(row["Price"].ToString())
                }).ToList();
            return products;
        }
    }
}
