using System;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;

namespace InventoryLibrary
{
    ///<summary> Json storage class </summary>
    public class JSONStorage
    {
        public Dictionary<string, object> objects = new Dictionary<string, object>();
        string filePath = @"./storage/inventory_manager.json";

        ///<summary> return all objects </summary>
        public Dictionary<string, object> All()
        {
            return (this.objects);
        }

        ///<summary> create a new object <summary>
        public void New(string obj)
        {
            if (obj == "item")
            {
                Item itemObj = new Item();
                objects.Add(obj + "." + itemObj.id, itemObj);
            }
            else if (obj == "user")
            {
                User userObj = new User();
                objects.Add(obj + "." + userObj.id, userObj);
            }
            if (obj == "inventory")
            {
                Inventory invObj = new Inventory();
                objects.Add(obj + "." + invObj.id, invObj);
            }
        }

        ///<summary> serializes objects in a Json file </summary>
        public void Save()
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            string data = JsonSerializer.Serialize<Dictionary<string, object>>(objects, options);
            using (StreamWriter sw = File.CreateText(filePath))
            {
                sw.WriteLine(data);
            }
        }

        ///<summary> deserializes objects </summary>
        public void Load()
        {
            string data = "{}";
            try
            {
                using (StreamReader sr = File.OpenText(filePath))
                {
                    data = File.ReadAllText(filePath);
                }
                objects = JsonSerializer.Deserialize<Dictionary<string, object>>(data); 
            }
            catch (JsonException)
            {
                Console.WriteLine("Json file does not contain info or is in the wrong format");
            }
        }
    }
}