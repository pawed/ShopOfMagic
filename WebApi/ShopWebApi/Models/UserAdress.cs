using System;
using System.Collections.Generic;

#nullable disable

namespace ShopWebApi.ModelsTMP
{
    public partial class UserAdress
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public int? AdressId { get; set; }
        public bool? Default { get; set; }

        public virtual Adress Adress { get; set; }
        public virtual User User { get; set; }
    }
}
