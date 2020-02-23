using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.Core.Models
{
    public class Area : BaseEntity
    {
        public string Barangay { get; set; }
        public string CityMunicipality { get; set; }
        public string Province { get; set; }
        public string Region { get; set; }
        public string Country { get; set; }
        public float DeliveryCharges { get; set; }
        public float Many { get; set; }
    }
}
