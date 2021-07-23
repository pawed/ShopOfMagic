using System;
using System.Collections.Generic;

#nullable disable

namespace ShopWebApi.ModelsTMP
{
    public partial class Order
    {
        public Order()
        {
            OrderHistories = new HashSet<OrderHistory>();
            OrderItems = new HashSet<OrderItem>();
        }

        public int Id { get; set; }
        public int UserId { get; set; }
        public string Status { get; set; }
        public string Comment { get; set; }
        public DateTime? CreatedAt { get; set; }

        public virtual User User { get; set; }
        public virtual ICollection<OrderHistory> OrderHistories { get; set; }
        public virtual ICollection<OrderItem> OrderItems { get; set; }
    }
}
