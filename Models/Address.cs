using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AddressManager_final.Models
{
    public class Address
    {
        public string buildingNumber { get; set; }
        public string streetName { get; set; }
        public string neighborhood { get; set; }
        public string quadrant { get; set; }
        public string city { get; set; }
        public string postalCOde { get; set; }
        public string stateOrProvince { get; set; }
        public string country { get; set; }
        public string prefectureName { get; set; }
        public string subArea { get; set; }
        public string furtherSubArea { get; set; }
        public string block { get; set; }
        public string subdivisionOrPrecinct { get; set; }

    }
}
