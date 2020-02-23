using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.Core.Models
{
    public class Supplier : BaseEntity
    {
        public string Company { get; set; }
        public string SupplierName { get; set; }
        public string Email { get; set; }
    }
}
