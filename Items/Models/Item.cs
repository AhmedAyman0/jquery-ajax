using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Items.Models
{
    public class Item
    {
        public int ID { get; set; }
        public string Code { get; set; }
        public string ArabicName { get; set; }
        public string EnglishName { get; set; }
        public ICollection<ItemColor> ItemColors { get; set; }

    }
}
