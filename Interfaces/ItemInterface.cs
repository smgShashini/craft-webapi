using CraftWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CraftWebApi.Interfaces
{
    public interface ItemInterface
    {
        Task<IEnumerable<Item>> GetItemsAsync();
    }
}
