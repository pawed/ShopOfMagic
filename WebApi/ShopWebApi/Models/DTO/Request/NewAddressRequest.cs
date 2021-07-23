using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopWebApi.DTO
{
    public class NewAddressRequest
    {
        public string StreetName { get; set; }
        public string StreetNumber { get; set; }
        public string ApartmentNumber { get; set; }
        public string City { get; set; }
        public string CountryCode { get; set; }
        public bool IsDefault { get; set; }
    }
}
