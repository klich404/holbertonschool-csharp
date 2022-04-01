using System;
using System.Collections.Generic;

namespace InventoryLibrary
{
    ///<summary> Item class </summary>
    public class Item : BaseClass
    {
        public string name { get; set; }
        public string description { get; set; }
        public float price { get; set; }
        public List<String> tags = new List<string>();

        ///<summary> Item constructor </summary>
        public Item (string name = "name", string description = "description", float price = 0.0f)
        {
            this.name = name;
            this.description = description;
            this.price = Convert.ToSingle(Math.Round(price, 2));
        }
    }
}