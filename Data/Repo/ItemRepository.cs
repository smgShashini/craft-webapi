
using CraftWebApi.Interfaces;
using CraftWebApi.Models;
using Microsoft.EntityFrameworkCore;

using System.Collections.Generic;

using System.Threading.Tasks;

namespace CraftWebApi.Data.Repo
{
    public class ItemRepository : ItemInterface
    {
        private readonly DataContext dc;

        public ItemRepository(DataContext dc)
        {
            this.dc = dc;
        }
        public async Task<IEnumerable<Item>> GetItemsAsync()
        {
            return await dc.Items.ToListAsync();
        }
    }
}
