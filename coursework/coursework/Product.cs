using System;
using System.Collections.Generic;

#nullable disable

namespace coursework
{
    public partial class Product
    {
        public Product()
        {
            OrdersProducts = new HashSet<OrdersProduct>();
        }

        public long IdProduct { get; set; }
        public string NameProduct { get; set; }
        public string QuantityProduct { get; set; }
        public long? IdUnitProduct { get; set; }
        public string PriceProduct { get; set; }

        public virtual UnitProduct IdUnitProductNavigation { get; set; }
        public virtual ICollection<OrdersProduct> OrdersProducts { get; set; }
    }
}
