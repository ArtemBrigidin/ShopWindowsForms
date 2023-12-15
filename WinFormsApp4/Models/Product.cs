﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp4.Models
{
    public class Product
    {
        public int ProductId { get; set; }

        public string Name { get; set; }

        public int ShopId { get; set; }

        public List<Shop> Shops { get; set; }
    }
}
