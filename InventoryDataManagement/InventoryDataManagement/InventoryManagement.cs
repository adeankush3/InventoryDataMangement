using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace InventoryDataManagement
{
    public class InventoryManagement
    {
        public void ReadData(string filepaath)
        {
            try
            {
                using (StreamReader streamReder = new StreamReader(filepaath))
                {
                    var json =streamReder.ReadToEnd();
                    var item = JsonConvert.JsonSerializer.Serialize< List < Inventory >> (json);
                    var options = new JsonSerializerOptions { WriteIndented = true };
                    string jsonString = JsonSerializer.Serialize(InventoryManagement, options);

                    Console.WriteLine(jsonString);
                    Console.WriteLine("Name\t" + "Price\t" + "Weight\t" + "Total amount");
                    foreach (var data in item)
                    {
                        Console.WriteLine(data.Name + "\t" + data.Price + "\t" + data.Weight + "\t" + data.Price * data.Weight);
                    }
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
            
        }
    }
}
