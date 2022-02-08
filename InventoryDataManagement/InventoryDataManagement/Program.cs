using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryDataManagement
{
   public class Program
    {
        static void Main(string[] args)
        {
            String filepath = @"F:\Bridgelabz\InventoryDataMangement\InventoryDataManagement\InventoryDataManagement\Inventory.json";
            InventoryManagement inventoryManagement = new InventoryManagement();
            inventoryManagement.ReadData(filepath);
        }
    }
}
