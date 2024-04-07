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

        public IEnumerable<Item> Seed()
        {
            List<Item> items = new List<Item>();
            for (int i = 0; i<500; i++)
            {
                Item item = new Item()
                {
                    Id = i,
                    Name = i.ToString(),
                    Quantity = i * 100,
                    CreateDate = DateTime.Now,
                    CreatedBy = "Me"

                };
                items.Add(item);
            }
            return items;
        }

        public IQueryable<Item> GetAllItemsQueryable()
        {
            IQueryable<Item> items = Seed().AsQueryable();
            return items;
        }

        public IEnumerable<Item> GetAllItemsEnumerable()
        {
            IEnumerable<Item> items = Seed();
            return items;
        }
    }
}
