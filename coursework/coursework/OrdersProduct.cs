using System;
using System.Collections.Generic;

#nullable disable

namespace coursework
{
    public partial class OrdersProduct
    {
        public long IdOrders { get; set; }
        public long IdProducts { get; set; }
        public long? Number { get; set; }

        public virtual Order IdOrdersNavigation { get; set; }
        public virtual Product IdProductsNavigation { get; set; }
    }
}
