using System;
using System.Collections.Generic;

#nullable disable

namespace ShopWebApi.ModelsTMP
{
    public partial class OrderItem
    {
        public OrderItem()
        {
            OrderItemsHistories = new HashSet<OrderItemsHistory>();
        }

        public int Id { get; set; }
        public int? OrderId { get; set; }
        public int? ProductId { get; set; }
        public string Status { get; set; }
        public string Comment { get; set; }
        public int? Quantity { get; set; }

        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
        public virtual ICollection<OrderItemsHistory> OrderItemsHistories { get; set; }
    }
}
