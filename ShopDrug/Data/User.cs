using System.Collections.Generic;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopDrug.Data
{
    public class User
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public virtual Status Statuses { get; set; }
        public int Age { get; set; }
        public Status Gender { get; set; }
    }
}