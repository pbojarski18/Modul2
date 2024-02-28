using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProgram
{
    public class ItemService
    {

        public List<Item> Items { get; set; }

        public List<Item> GetAllItems()
        {
            return Items;
        }

        public int AddNewItem(int id, string name = "Apple")
        {
            Item item = new Item() { Id = id, Name = name };
            Items.Add(item);
            return item.Id;
        }

        public Item Method(int id, string name)
        {
            Item item = new Item() { Id = id, Name = name };
            name = "New name";
            return item;
        }
    }
}
