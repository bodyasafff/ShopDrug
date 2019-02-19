using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopDrug.Data
{
    public class Adresses
    {
        public int Id { get; set; }
        public virtual ICollection<Country> Countries { get; set; }
        public virtual ICollection<Building> Buildings { get; set; }
    }
}
