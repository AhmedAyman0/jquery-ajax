﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Items.Models
{
    public class Color
    {
        public int ID { get; set; }
        public string ColorName { get; set; }
        public ICollection<ItemColor> ColorItems { get; set; }

    }
}
