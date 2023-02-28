using System;
using System.Collections.Generic;

#nullable disable

namespace coursework
{
    public partial class Status
    {
        public Status()
        {
            Orders = new HashSet<Order>();
        }

        public long IdStatus { get; set; }
        public string NameStatus { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
