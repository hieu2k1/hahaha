using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Humman.Models
{
    public class EFStoreRepository : IStoreRepository
    {
        private StoreDbContext context;
        public EFStoreRepository(StoreDbContext ctx)
        {
            context = ctx;
        }

        public IQueryable<Product> Products => context.Products;
    }
}
