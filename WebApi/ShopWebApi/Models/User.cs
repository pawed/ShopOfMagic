using System;
using System.Collections.Generic;

#nullable disable

namespace ShopWebApi.ModelsTMP
{
    public partial class User
    {
        public User()
        {
            Orders = new HashSet<Order>();
            ShoppingCarts = new HashSet<ShoppingCart>();
            UserAdresses = new HashSet<UserAdress>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
        public DateTime? CreatedAt { get; set; }
        public int? AdressId { get; set; }
        public string Role { get; set; }
        public string Phone { get; set; }
        public string EMail { get; set; }
        public byte[] Passwordhash { get; set; }
        public byte[] Passwordsalt { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<ShoppingCart> ShoppingCarts { get; set; }
        public virtual ICollection<UserAdress> UserAdresses { get; set; }
    }
}
