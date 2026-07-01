using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desktop_web_proj1.Model
{
    public class ShoeInventoryTableModel
    {
        
        
        public int id { get; set; }
        public string shoeName { get; set; }
        public string shoeDescription { get; set; }
        public string shoePrice { get; set; }
        public int shoeSize { get; set; }
        public int quantity { get; set; }
    }
}
