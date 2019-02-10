using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Amazing_Product_API.Models;


namespace Amazing_Product_API.Controllers
{
    public class ProductController : ApiController
    {
        public static List<Product> products = new List<Product>();
        public static int PageLoadFlag = 1;

        // GET: api/Product
        public List<Product> GetAllProducts()
        {
            if (PageLoadFlag == 1)
            {
                var data = new DataStorage();
                PageLoadFlag++;
                products = data.GetData();
                return products;
            }

            return products;
        }

        // GET: api/Product/5
        public IHttpActionResult GetProduct(int id)
        {
            var product = products.FirstOrDefault(x => x.ID == id);

            if (product == null)
                return NotFound();

            return Ok(product);
        }

        // POST: api/Product
        public void Post(Product product)
        {
            product.ID = products.Count + 1;
            products.Add(product);
        }

        // PUT: api/Product/5
        public void Put(int id, Product product)
        {
            var record = products.FirstOrDefault(x => x.ID == id);

            if (record != null)
            {
                products.Remove(record);
                products.Add(product);
            }
        }

        // DELETE: api/Product/5
        public void Delete(int id)
        {
            foreach (var product in products)
            {
                if (product.ID == id)
                {
                    products.Remove(product);
                    break;
                }
            }
        }
    }
}
