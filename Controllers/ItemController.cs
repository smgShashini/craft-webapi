using CraftWebApi.Data;
using CraftWebApi.Interfaces;
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
        private readonly UnitOfWorkInterface uow;

        //private readonly DataContext dc;
        //private readonly ItemInterface repo;

        public ItemController(UnitOfWorkInterface uow)
        {
            //this.dc = dc;
            //this.repo = repo;
            this.uow = uow;
        }
        //private readonly DataContext dc;
       
        [HttpGet]
        public async Task<ActionResult> GetItems()
        {
            var itemlist = await uow.ItemRepository.GetItemsAsync();
            return Ok(itemlist);
        }
    }
}
