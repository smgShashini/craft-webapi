using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CraftWebApi.Interfaces
{
     public interface UnitOfWorkInterface
    {
        ItemInterface ItemRepository { get; }
    }
}
