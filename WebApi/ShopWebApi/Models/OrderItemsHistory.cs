using System;
using System.Collections.Generic;

#nullable disable

namespace ShopWebApi.ModelsTMP
{
    public partial class OrderItemsHistory
    {
        public int Id { get; set; }
        public int OrderItemsId { get; set; }
        public string Status { get; set; }
        public string Title { get; set; }
        public string Comment { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public virtual OrderItem OrderItems { get; set; }
    }
}
