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

        public ItemCategory Category { get; set; }
    }
    public enum ItemCategory
    {
        Food = 1,
        Equipment,
        Others

    }
}





