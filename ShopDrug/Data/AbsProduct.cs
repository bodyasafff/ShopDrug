﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopDrug.Data
{
    public class AbsProduct
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Categori> Categoris { get; set; }
    }
}
