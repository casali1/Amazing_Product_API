using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Amazing_Product_API.Models
{
    public class DataStorage
    {
        public List<Product> GetData()
        {
            return new List<Product>
            {
                new Product{ID=1, Name="Truck", Category="Toy", Price=18 },
                new Product{ID=2, Name="Checkers", Category="Game", Price=5},
                new Product{ID=3, Name="Soldier", Category="Toy", Price=2 }
            };
        }
    }
}