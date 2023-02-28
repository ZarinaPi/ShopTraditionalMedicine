using System;
using System.Collections.Generic;

#nullable disable

namespace coursework
{
    public partial class UnitProduct
    {
        public UnitProduct()
        {
            Products = new HashSet<Product>();
        }

        public long IdUnitProduct { get; set; }
        public string NameUnitProduct { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
