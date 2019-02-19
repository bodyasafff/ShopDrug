using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopDrug.Data
{
    public class Order
    {
        public int Id { get; set; }
        public virtual ICollection<User> Users { get; set; }
        public virtual ICollection<RealProduct> RealProducts { get; set; }
        public virtual ICollection<AbsProduct> AbsProducts { get; set; }
        public string OrderDate { get; set; }
        public int Quantity { get; set; }
    }
}
