using System;
using System.Collections.Generic;

#nullable disable

namespace coursework
{
    public partial class Order
    {
        public Order()
        {
            OrdersProducts = new HashSet<OrdersProduct>();
        }

        public long IdOrder { get; set; }
        public long? IdClient { get; set; }
        public long? IdStatus { get; set; }
        public long? IdUser { get; set; }
        public string PriceOrders { get; set; }

        public virtual Client IdClientNavigation { get; set; }
        public virtual Status IdStatusNavigation { get; set; }
        public virtual User IdUserNavigation { get; set; }
        public virtual ICollection<OrdersProduct> OrdersProducts { get; set; }
    }
}
