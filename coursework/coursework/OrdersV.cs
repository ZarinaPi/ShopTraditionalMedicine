using System;
using System.Collections.Generic;

#nullable disable

namespace coursework
{
    public partial class OrdersV
    {
        public long? IdOrder { get; set; }
        public string SurnameClient { get; set; }
        public string NameStatus { get; set; }
        public long? IdUser { get; set; }
        public string PriceOrders { get; set; }
    }
}
