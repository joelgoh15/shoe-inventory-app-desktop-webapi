using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace shoe_inventory_desktop_webapi.Models
{
    public class PostShoeInventoryTableModel
    {
        public string shoeName { get; set; }
        public string shoeDescription { get; set; }
        public string shoePrice { get; set; }
        public int shoeSize { get; set; }
        public int quantity { get; set; }
    }
}