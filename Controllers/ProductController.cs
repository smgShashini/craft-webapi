using CraftWebApi.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CraftWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly UnitOfWorkInterface uow;
        public ProductController(UnitOfWorkInterface uow)
        {
            this.uow = uow;

        }

        [HttpGet]
        public async Task<ActionResult> GetProducts()
        {
            var productList = await uow.ProductRepository.GetProductAsync();
            return Ok(productList);
        }

        [HttpGet("cat/{id}")]
        public async Task<ActionResult> GetProductsByCatID(int id)
        {
            var catProductList = await uow.ProductRepository.GetProductsByCatId(id);
            return Ok(catProductList);
        }
    }
}
