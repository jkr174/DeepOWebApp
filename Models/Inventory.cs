using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeepOWebApp.Models
{
    public class Inventory
    {
        public int ItemID { get; set; }
        public string ItemName { get; set; }
        public string Catagory { get; set; }
        public string Subcategory { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int TotalQty { get; set; }
        public int AvailableQty { get; set; }
        public int OutAtm { get; set; }
    }
}
