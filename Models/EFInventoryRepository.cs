using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeepOWebApp.Models
{
    public class EFInventoryRepository : IInventoryRepository
    {
        private InventoryDbContext context;
        public EFInventoryRepository(InventoryDbContext ctx)
        {
            context = ctx;
        }
        public IQueryable<Inventory> Inventories => context.Inventories;
    }
}
