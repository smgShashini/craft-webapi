using CraftWebApi.Data;
using CraftWebApi.Data.Repo;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CraftWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : ControllerBase

    {
        private readonly DataContext dc;
        private readonly ItemInterface repo;

        public ItemController(DataContext dc, ItemInterface repo)
        {
            this.dc = dc;
            this.repo = repo;
        }
        //private readonly DataContext dc;
       
        [HttpGet]
        public async Task<ActionResult> GetItems()
        {
            var itemlist = await repo.GetItemsAsync();
            return Ok(itemlist);
        }
    }
}
