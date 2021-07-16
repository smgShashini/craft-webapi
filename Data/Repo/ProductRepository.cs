using CraftWebApi.Interfaces;
using CraftWebApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CraftWebApi.Data.Repo
{
    public class ProductRepository : IProductInterface
    {
        private readonly DataContext dc;
        public ProductRepository(DataContext dc)
        {
            this.dc = dc;
        }
        public async Task<IEnumerable<Product>> GetProductAsync()
        {
            return await dc.Products.ToListAsync();

        }
        public async Task<IEnumerable<Product>> GetProductsByCatId(int catId)
        {
            var catList= from b in dc.Products
                                     where (b.CategoryId==catId)
                                     select b;

            return (catList);

        }
    }
}
