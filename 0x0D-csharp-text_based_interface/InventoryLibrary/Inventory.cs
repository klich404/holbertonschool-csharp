using System;

namespace InventoryLibrary
{
    public class Inventory : BaseClass
    {
        public User user { get; set; }
        public Item item { get; set; }
        public string user_id { get; set; }
        public string item_id { get; set; } 
        public  int quantity { get; set; }

        public Inventory(User user = null, Item item = null, int quantity = 1)
        {
            if (quantity < 0)
                this.quantity = 1;
            this.quantity = quantity;
            if (user != null)
                this.user_id = user.id;
            else
                this.user_id = "user_id";
            if (item != null)
                this.item_id = item.id;
            else
                this.item_id = "item_id";
        }
    }
}