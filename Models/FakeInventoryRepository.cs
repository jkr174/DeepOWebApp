using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeepOWebApp.Models
{
    public class FakeInventoryRepository : IInventoryRepository
    {
        public IQueryable<Inventory> Inventories => new List<Inventory>
        {
            new Inventory {ItemName = "Handsaw", Price = 25.99},
            new Inventory {ItemName = "Chainsaw", Price = 179.99},
            new Inventory {ItemName = "Hand Drill", Price = 95.99}
        }.AsQueryable<Inventory>();
    }
}
