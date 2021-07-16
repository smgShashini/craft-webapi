using CraftWebApi.Data.Repo;
using CraftWebApi.Interfaces;

namespace CraftWebApi.Data
{
    public class UnitOfWork : UnitOfWorkInterface
    {
        private readonly DataContext dc;

        public UnitOfWork(DataContext dc)
        {
            this.dc = dc;
        }
        public ItemInterface ItemRepository =>
            new ItemRepository(dc);


        public IProductInterface ProductRepository =>
            new ProductRepository(dc);
    }
}
