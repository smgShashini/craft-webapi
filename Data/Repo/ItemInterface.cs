using CraftWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CraftWebApi.Data.Repo
{
    public interface ItemInterface
    {
        Task<IEnumerable<Item>> GetItemsAsync();
    }
}
