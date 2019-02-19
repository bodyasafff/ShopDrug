using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopDrug.Data
{
    public class RealProduct
    {
        public int Id { get; set; }
        public int Price { get; set; }
        public virtual ICollection<AbsProduct> AbsProducts { get; set; }
        public virtual ICollection<Producer> Producers { get; set; }
        public string ProductionDate { get; set; }
        public string ExpieesDate { get; set; }
        public int Quantity { get; set; }
    }
}
