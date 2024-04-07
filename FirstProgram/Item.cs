using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProgram
{
    public class Item
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Quantity { get; set; }

        public DateTime CreateDate { get; set; }

        public string CreatedBy { get; set; }

        public ItemType ItemType { get; set; }

        public Item(int id, string name, ItemType itemType)
        {
            Id = id;
            Name = name;
            ItemType = itemType;
        }

        public Item()
        {
            
        }
    }


    public enum ItemType
    {
        Food = 1,
        Equipment,
        Others

    }
}





