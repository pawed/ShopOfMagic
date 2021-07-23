using System;
using System.Collections.Generic;

#nullable disable

namespace ShopWebApi.ModelsTMP
{
    public partial class Adress
    {
        public Adress()
        {
            UserAdresses = new HashSet<UserAdress>();
        }

        public int Id { get; set; }
        public string StreetName { get; set; }
        public string StreetNumber { get; set; }
        public string ApartmentNumber { get; set; }
        public string City { get; set; }
        public string CountryCode { get; set; }

        public virtual ICollection<UserAdress> UserAdresses { get; set; }
    }
}
