using System;
using System.Collections.Generic;

#nullable disable

namespace coursework
{
    public partial class Client
    {
        public Client()
        {
            Orders = new HashSet<Order>();
        }

        public long IdClient { get; set; }
        public string SurnameClient { get; set; }
        public string NameClient { get; set; }
        public string PatronymicClient { get; set; }
        public string MobileNumberClient { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
