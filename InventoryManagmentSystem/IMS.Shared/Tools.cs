﻿using System;
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
        public int PurchasePrice { get; set; }
        public string DateTransfer { get; set; }
        public string Conditions {  get; set; }
        public int InventoryId { get; set; }
        public Inventory Inventory { get; set; }
        public Recipient Recipient {  get; set; }
        public int RecipientId { get; set;}

    }
}
