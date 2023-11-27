using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.Shared
{
    public class Tools
    {
        public int ToolsId { get; set; }
        public string TypeName { get; set; }
        public string CompanyName { get; set; }
        public int InventoryNumber { get; set; }
        public int InventoryId { get; set; }
        public Inventory Inventory { get; set; }

    }
}
