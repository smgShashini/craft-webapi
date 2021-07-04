using CraftWebApi.Data;
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
        public ItemController(DataContext  dc )
        {
            this.dc = dc;
        }

        [HttpGet]
        public async Task<IActionResult> GetItemList()
        {
            var doclist = await dc.Items.ToListAsync();
            return Ok(doclist);


        }
    }
}
