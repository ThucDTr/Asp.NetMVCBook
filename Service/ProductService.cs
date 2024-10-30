using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspMVCEcomerce.Models;

namespace AspMVCEcomerce.Service
{
    public class ProductService : List<Product>
    {
        public ProductService(){
            this.AddRange(new Product[] {
                new Product() { Id = 1, Name = "Iphone X", Price = 1000},
                new Product() { Id = 2, Name = "Iphone 12", Price = 2000},
                new Product() { Id = 3, Name = "Iphone 13", Price = 2200},
                new Product() { Id = 4, Name = "Iphone 14", Price = 2500},
            });
        }
    }
}